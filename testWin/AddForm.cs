using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace kursWin
{
    //клас AddForm - вікно додавання нового елементу в таблицю
    public partial class AddForm : Form
    {
        private MainForm parent;
        bool errorName;
        bool errorType;
        bool errorPow;
        bool errorCon;
        bool errorVol;
        public AddForm()
        {
            InitializeComponent();
            powerSpinBox.Controls[0].Visible = false;
            consumptionSpinBox.Controls[0].Visible = false;
            volumeSpinBox.Controls[0].Visible = false;
            
            errorName = false;
            errorType = false;
            errorPow  = false;
            errorCon  = false;
            errorVol  = false;


            buttonAdd.BackColor = ColorElem.ButtonBackColor;
            buttonAdd.ForeColor = ColorElem.ButtonForeColor;

            buttonCancel.BackColor = ColorElem.ButtonBackColor;
            buttonCancel.ForeColor = ColorElem.ButtonForeColor;  
        }
        public AddForm(MainForm parent)
        {
            InitializeComponent();
            errorName = false;
            errorType = false;
            powerSpinBox.Controls[0].Visible = false;
            consumptionSpinBox.Controls[0].Visible = false;
            volumeSpinBox.Controls[0].Visible = false;
            this.parent = parent;

            BackColor = ColorElem.BackColor;
            ForeColor = ColorElem.ForeColor;

            buttonAdd.BackColor = ColorElem.ButtonBackColor;
            buttonAdd.ForeColor = ColorElem.ButtonForeColor;

            buttonCancel.BackColor = ColorElem.ButtonBackColor;
            buttonCancel.ForeColor = ColorElem.ButtonForeColor;
        }
        //методи для роботи - візуальни компонентами
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (errorName) throw new Exception("The name must not be empty!");
                if (errorType) throw new Exception("The type must not be empty");
                if (errorPow) throw new Exception("The power must be greater than 10");
                if (errorCon) throw new Exception("The consumption must be greater than 10");
                if (errorVol) throw new Exception("The volume must be greater than 10");

                parent.mylist.Add(new cVehicle(nameTextBox.Text, (typeComboBox.Text == "Car") ? (types.CAR) : (types.TRUCK),
                    Decimal.ToDouble(powerSpinBox.Value), Decimal.ToDouble(consumptionSpinBox.Value),
                    Decimal.ToDouble(volumeSpinBox.Value)));
                parent.WriteTable(ref parent.mylist, ref parent.tableList);
                parent.IsSaved = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                errorProviderName.SetError(nameTextBox, "Enter name of car!");
                errorName = true;
            }
            else
            {
                errorProviderName.Clear();
                errorName = false;
            }
        }

        private void typeComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (typeComboBox.SelectedIndex < 0)
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

        private void powerSpinBox_Validating(object sender, CancelEventArgs e)
        {
            if (powerSpinBox.Value < 10)
            {
                errorProviderPow.SetError(powerSpinBox, "Too small value!");
                errorPow = true;
            }
            else
            {
                errorProviderPow.Clear();
                errorPow = false;
            }
        }

        private void consumptionSpinBox_Validating(object sender, CancelEventArgs e)
        {
            if (consumptionSpinBox.Value < 10)
            {
                errorProviderCon.SetError(consumptionSpinBox, "Too small value!");
                errorCon = true;
            }
            else
            {
                errorProviderCon.Clear();
                errorCon = false;
            }
        }

        private void volumeSpinBox_Validating(object sender, CancelEventArgs e)
        {
            if (volumeSpinBox.Value < 10)
            {
                errorProviderVol.SetError(volumeSpinBox, "Too small value!");
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
