using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace kursWin
{
    //клас FilterForm - для вікна фільтрування та сортування елементів
    public partial class FilterForm : Form
    {
        MainForm parent;
        public FilterForm()
        {
            InitializeComponent();
        }
        public FilterForm(MainForm p)
        {
            InitializeComponent();
            parent = p;
            trackBarPower.Value = 100;
            trackBarCon.Value = 100;
            trackBarVolume.Value = 100;

            BackColor = ColorElem.BackColor;

            buttonAccept.BackColor = ColorElem.ButtonBackColor;
            buttonAccept.ForeColor = ColorElem.ButtonForeColor;

            button2.BackColor = ColorElem.ButtonBackColor;
            button2.ForeColor = ColorElem.ButtonForeColor;
        }

        //метод для фільтрування елементів лише по одному

        private void FindOnlyName(ref List<cVehicle> filterlist)
        {
            List<cVehicle> temp = new List<cVehicle>();
            foreach (var i in filterlist)
            {
                bool add = true;
                foreach(var j in temp)
                {
                    if(i.Name == j.Name)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    temp.Add(i);
                }
            }
            filterlist.Clear();
            foreach(var i in temp)
            {
                filterlist.Add(i);
            }
        }

        //метод фільтрування по всіх іменах

        private void FindAllNames(ref List<cVehicle> mylist)
        {
            List<string> names = new List<string>();
            foreach (var i in mylist)
            {
                bool add = true;
                foreach (string k in names)
                {
                    if (k == i.Name)
                    {
                        add = false;
                        break;
                    }
                }
                if (add) 
                { 
                   foreach( var j in mylist)
                   {
                        if(i.Name == j.Name)
                        {
                            if(i.Type != j.Type)
                            {
                                names.Add(i.Name);
                                break;
                            }
                        }
                    }    
                }
            }
            string mes = "Name of cars, with 2 types:\n";
            foreach (var i in names)
            {
                mes += i + "\n";
            }
            MessageBox.Show(mes, "List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //метод групування за типом
        
        private void GroupByType(ref List<cVehicle> filterlist)
        {
            if (filterlist.Count <= 1) return;

            List<cVehicle> temp = new List<cVehicle>();
            for (int i = 0; i < filterlist.Count; ++i)
            {
                if (filterlist[i].Type == filterlist[0].Type)
                {
                    temp.Add(filterlist[i]);
                }
            }
            for (int i = 0; i < filterlist.Count; ++i)
            {
                if (filterlist[i].Type != filterlist[0].Type)
                {
                    temp.Add(filterlist[i]);
                }
            }
            filterlist.Clear();
            foreach (var i in temp)
            {
                filterlist.Add(i);
            }
        }

        //иетоди для роботи з візуальними компонентами

        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilter.Checked)
            {
                groupBox.Enabled = true;
            }
            else
            {
                groupBox.Enabled = false;
            }
        }

        private void checkBoxSort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSort.Checked)
            {
                groupBoxSort.Enabled = true;
            }
            else
            {
                groupBox.Enabled = false;
            }
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxName.Checked)
            {
                comboBoxName.Enabled = true;
            }
            else
            {
                comboBoxName.Enabled = false;
            }
        }

        private void checkBoxType_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxType.Checked)
            {
                comboBoxType.Enabled = true;
            }
            else
            {
                comboBoxType.Enabled = false;
            }
        }

        private void checkBoxPower_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPower.Checked)
            {
                trackBarPower.Enabled = true;
            }
            else
            {
                trackBarPower.Enabled = false;
                trackBarPower.Value = 100;
            }
        }

        private void checkBoxCon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCon.Checked)
            {
                trackBarCon.Enabled = true;
            }
            else
            {
                trackBarCon.Enabled = false;
                trackBarCon.Value = 100;
            }
        }

        private void checkBoxVolume_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVolume.Checked)
            {
                trackBarVolume.Enabled = true;
            }
            else
            {
                trackBarVolume.Enabled = false;
                trackBarVolume.Value = 100;
            }
        }

        private void trackBarPower_ValueChanged(object sender, EventArgs e)
        {
            labelPow.Text = trackBarPower.Value.ToString();
        }

        private void trackBarCon_ValueChanged(object sender, EventArgs e)
        {
            labelCon.Text = trackBarCon.Value.ToString();
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            labelVolume.Text = trackBarVolume.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxType_Validating(object sender, CancelEventArgs e)
        {
            if(checkBoxType.Checked)
            if (comboBoxType.SelectedIndex < 0)
            {
                errorProviderName.SetError(comboBoxType, "Choose a type!");
                errorType = true;
            }
            else
            {
                errorProviderName.Clear();
                errorType = false;
            }
        }
        bool errorName;
        bool errorType;
        private void comboBoxName_Validating(object sender, CancelEventArgs e)
        {
            if(checkBoxName.Checked)
            if (String.IsNullOrWhiteSpace(comboBoxName.Text))
            {
                errorProviderName.SetError(comboBoxName, "Enter name");
                errorName = true;
            }
            else
            {
                errorProviderName.Clear();
                errorName = false;
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (errorName) throw new Exception("Please, put name of Vehicle!");
                if (errorType) throw new Exception("Please, choose type of a Vehicle");

                if (checkBoxName.Checked && string.Equals(comboBoxName.Text, "All names") &&
                    checkBoxType.Checked && comboBoxType.SelectedIndex == 0)
                {
                    FindAllNames(ref parent.mylist);
                    return;
                }
                if(checkBoxName.Checked && string.Equals(comboBoxName.Text, "Only one name") && checkBoxSort.Checked)
                {
                    cFilter filterT = new cFilter(sort: true);
                    if (comboBoxSortBy.SelectedIndex == 0) filterT.SetSort(name: true);
                    if (comboBoxSortBy.SelectedIndex == 1) filterT.SetSort(type: true);
                    if (comboBoxSortBy.SelectedIndex == 2) filterT.SetSort(power: true);
                    if (comboBoxSortBy.SelectedIndex == 3) filterT.SetSort(con: true);
                    if (comboBoxSortBy.SelectedIndex == 4) filterT.SetSort(vol: true);
                    if (comboBoxSortBy.SelectedIndex == 5) filterT.SetSort(len: true);

                    filterT.FlagSort = (comboBoxHighLow.SelectedIndex == 1) ? (true) : (false);
                    filterT.FilterList(ref parent.mylist, ref parent.filterlist);
                    FindOnlyName(ref parent.filterlist);
                    if (checkBoxGroup.Checked)
                    {
                        GroupByType(ref parent.filterlist);
                    }
                    parent.WriteTable(ref parent.filterlist, ref parent.tableList);
                    return;
                }

                cFilter filter = new cFilter(checkBoxFilter.Checked, checkBoxSort.Checked, checkBoxName.Checked,
                    checkBoxType.Checked, checkBoxPower.Checked, checkBoxCon.Checked, checkBoxVolume.Checked);
                filter.SetFilter(comboBoxName.Text, comboBoxType.SelectedIndex - 1, Convert.ToDouble(labelPow.Text),
                    Convert.ToDouble(labelCon.Text), Convert.ToDouble(labelVolume.Text));
                if (comboBoxSortBy.SelectedIndex == 0) filter.SetSort(name: true);
                if (comboBoxSortBy.SelectedIndex == 1) filter.SetSort(type: true);
                if (comboBoxSortBy.SelectedIndex == 2) filter.SetSort(power: true);
                if (comboBoxSortBy.SelectedIndex == 3) filter.SetSort(con: true);
                if (comboBoxSortBy.SelectedIndex == 4) filter.SetSort(vol: true);
                filter.FlagSort = (comboBoxHighLow.SelectedIndex == 1)?(true):(false);
                filter.FilterList(ref parent.mylist, ref parent.filterlist);
                if (checkBoxGroup.Checked) GroupByType(ref parent.filterlist);
                parent.WriteTable(ref parent.filterlist, ref parent.tableList);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxName_Validated(object sender, EventArgs e)
        {
            if (!checkBoxName.Checked)
            {
                errorProviderName.Clear();
                errorName = false;
            }
        }

        private void comboBoxType_Validated(object sender, EventArgs e)
        {
            if (!checkBoxType.Checked)
            {
                errorProviderType.Clear();
                errorType = false;
            }
        }
    }
}
