using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace kursWin
{
    //клас EditForm - для роботи з вікном редагування елемента таблиці
    public partial class EditForm : Form
    {
        MainForm parent;
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            errorName = false;
            errorType = false;
            errorPow = false;
            errorCon = false;
            errorVol = false;


            BackColor = ColorElem.BackColor;

            buttonCancel.BackColor = ColorElem.ButtonBackColor;
            buttonCancel.ForeColor = ColorElem.ForeColor;

            buttonDelete.BackColor = ColorElem.ButtonBackColor;
            buttonDelete.ForeColor = ColorElem.ForeColor;

            buttonEdit.BackColor = ColorElem.ButtonBackColor;
            buttonEdit.ForeColor = ColorElem.ForeColor;

        }
        int id;
        bool errorName;
        bool errorType;
        bool errorPow;
        bool errorCon;
        bool errorVol;

        //методи для роботи з візуальними компонентами

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (errorName) throw new Exception("The name must not be empty!");
                if (errorType) throw new Exception("The type must not be empty");
                if (errorPow)  throw new Exception("The power must be greater than 10");
                if (errorCon)  throw new Exception("The consumption must be greater than 10");
                if (errorVol)  throw new Exception("The volume must be greater than 10");
                int i;
                for (i = 0; i < parent.mylist.Count; ++i)
                {
                    if (parent.mylist[i].Id == id) break;
                }
                parent.mylist[i].Name = textBox1.Text;
                parent.mylist[i].Type = (comboBox1.SelectedIndex == 0) ? (types.CAR) : (types.TRUCK);
                parent.mylist[i].Power = Convert.ToDouble(numericPow.Value);
                parent.mylist[i].Consumption = Convert.ToDouble(numericCon.Value);
                parent.mylist[i].Volume = Convert.ToDouble(numericVol.Value);
                parent.WriteTable(ref parent.mylist, ref parent.tableList);
                parent.IsSaved = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            int index = parent.tableList.CurrentRow.Index;
            id = Convert.ToInt32(parent.tableList.Rows[index].Cells[5].Value);


            int i;
            for (i = 0; i < parent.mylist.Count; ++i)
            {
                if (parent.mylist[i].Id == id) break;
            }
            textBox1.Text = parent.mylist[i].Name;
            comboBox1.Text = (parent.mylist[i].Type == types.CAR) ? ("Car") : ("Truck");
            numericPow.Value = Convert.ToDecimal(parent.mylist[i].Power);
            numericCon.Value = Convert.ToDecimal(parent.mylist[i].Consumption);
            numericVol.Value = Convert.ToDecimal(parent.mylist[i].Volume);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProviderName.SetError(textBox1, "Enter name of car!");
                errorName = true;
            }
            else
            {
                errorName = false;
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                errorProviderType.SetError(typeComboBox, "Choose any type!");
                errorType = true;
            }
            else
            {
                errorType = false;
                errorProviderType.Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < parent.mylist.Count; ++i)
            {
                if (parent.mylist[i].Id == id) break;
            }
            parent.mylist.RemoveAt(i);
            parent.WriteTable(ref parent.mylist, ref parent.tableList);
            Close();
        }

        private void numericPow_Validating(object sender, CancelEventArgs e)
        {
            if(numericPow.Value < 10)
            {
                errorProviderPow.SetError(numericPow, "Too small value!");
                errorPow = true;
            }
            else
            {
                errorProviderPow.Clear();
                errorPow = false;
            }
        }

        private void numericCon_Validating(object sender, CancelEventArgs e)
        {
            if (numericCon.Value < 10)
            {
                errorProviderCon.SetError(numericCon, "Too small value!");
                errorCon = true;
            }
            else
            {
                errorProviderCon.Clear();
                errorCon = false;
            }
        }

        private void numericVol_Validating(object sender, CancelEventArgs e)
        {
            if (numericVol.Value < 10)
            {
                errorProviderVol.SetError(numericVol, "Too small value!");
                errorVol = true;
            }
            else
            {
                errorProviderVol.Clear();
                errorVol = false;
            }
        }
    }
}
