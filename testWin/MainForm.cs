using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
namespace kursWin
{
    //клас MainForm - головне меню програми
    public partial class MainForm : Form
    {
        public List<cVehicle> mylist;
        public List<cVehicle> filterlist;
        public string Filepath { get; set; }
        public bool IsSaved { get; set; }

        public MainForm()
        {
            InitializeComponent();
            mylist = new List<cVehicle>();
            filterlist = new List<cVehicle>();
            tableList.Rows.Clear();

            BackColor = ColorElem.BackColor;

            tableList.BackgroundColor = ColorElem.BackColor;

            buttonOpen.BackColor = ColorElem.ButtonBackColor;
            buttonOpen.ForeColor = ColorElem.ButtonForeColor;

            buttonSaveAs.BackColor = ColorElem.ButtonBackColor;
            buttonSaveAs.ForeColor = ColorElem.ButtonForeColor;


            buttonAdd.BackColor = ColorElem.ButtonBackColor;
            buttonAdd.ForeColor = ColorElem.ButtonForeColor;

            buttonEdit.BackColor = ColorElem.ButtonBackColor;
            buttonEdit.ForeColor = ColorElem.ButtonForeColor;

            buttonFilter.BackColor = ColorElem.ButtonBackColor;
            buttonFilter.ForeColor = ColorElem.ButtonForeColor;

            buttonDeleteAll.BackColor = ColorElem.ButtonBackColor;
            buttonDeleteAll.ForeColor = ColorElem.ButtonForeColor;

            IsSaved = true;

        }

        //методи для роботи з таблицею

        public void Save()
        {
            ReadTable(ref mylist, ref tableList);
            IsSaved = true;
        }

        //метод для запису у файл
        
        async public void WriteFile()
        {
            FileStream fs = new FileStream(Filepath, FileMode.Create);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true,
            };
            if (fs.CanWrite)
                await JsonSerializer.SerializeAsync<List<cVehicle>>(fs, mylist, options);
            fs.Close();

        }

        //метод для зчитування з файлу

        public void ReadFile()
        {
            FileStream fs = new FileStream(Filepath, FileMode.Open);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true,
            };
            byte[] arr = new byte[fs.Length];
            if (!fs.CanRead)
            {
                fs.Close();
                return;
            }
            mylist.Clear();
            fs.Read(arr, 0, arr.Length);
            fs.Close();
            string textFromFile = System.Text.Encoding.Default.GetString(arr);
            mylist = JsonSerializer.Deserialize<List<cVehicle>>(textFromFile);
        }

        //метод для запису даних у таблицю

        public void WriteTable(ref List<cVehicle> list, ref DataGridView table)
        {
            table.Rows.Clear();
            foreach (var i in list)
            {
                table.Rows.Add(new object[] { i.Name, (i.Type == types.CAR) ? ("Car") : ("Truck"), i.Power, i.Consumption, i.Volume, i.Id });
            }


        }

        //метод для читання даних з таблиці

        public void ReadTable(ref List<cVehicle> list, ref DataGridView table)
        {
            list.Clear();
            for (int i = 0; i < table.RowCount; ++i)
            {

                list.Add(new cVehicle(tableList.Rows[i].Cells[0].Value.ToString(),
                    ((tableList.Rows[i].Cells[1].Value.ToString() == "Car") ? (types.CAR) : (types.TRUCK)),
                    Convert.ToDouble(tableList.Rows[i].Cells[2].Value.ToString()), Convert.ToDouble(tableList.Rows[i].Cells[3].Value.ToString()),
                    Convert.ToDouble(tableList.Rows[i].Cells[4].Value.ToString())
                    ));
            }
        }

        //методи для роботи з візуальними компонентами

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm addForm = new AddForm(this);
                addForm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (!IsSaved)
            {
                MessageForm mes = new MessageForm(this);
                mes.ShowDialog();
            }

            openFileDialog.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            editForm.ShowDialog();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm(this);
            filterForm.ShowDialog();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (!IsSaved)
            {
                MessageForm mes = new MessageForm(this);
                mes.ShowDialog();
            }
            tableList.Rows.Clear();
            mylist.Clear();
        }

        public void buttonSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Filepath = saveFileDialog.FileName;
            ReadTable(ref mylist, ref tableList);
            WriteFile();
            IsSaved = true;
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Filepath = openFileDialog.FileName;
            ReadFile();
            WriteTable(ref mylist, ref tableList);
            IsSaved = true;
        }

        private void tableList_SelectionChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = true;
            buttonFilter.Enabled = true;
            buttonDeleteAll.Enabled = true;
            if (!IsSaved) label1.Text = "CarViewer*";
            if (IsSaved)  label1.Text = "CarViewer";
        }



        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            buttonOpen_Click(sender, e);
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            buttonSaveAs_Click(sender, e);
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            buttonAdd_Click(sender, e);
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            buttonEdit_Click(sender, e);
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            buttonDeleteAll_Click(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (tableList.RowCount == 0)
            {
                contextMenuStrip1.Items[3].Enabled = false;
                contextMenuStrip1.Items[4].Enabled = false;
                contextMenuStrip1.Items[5].Enabled = false;
                contextMenuStrip1.Items[6].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items[3].Enabled = true;
                contextMenuStrip1.Items[4].Enabled = true;
                contextMenuStrip1.Items[5].Enabled = true;
                contextMenuStrip1.Items[6].Enabled = true;
            }
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            buttonOpen_Click(sender, e);
        }

        private void toolStripSaveAs_Click(object sender, EventArgs e)
        {
            buttonSaveAs_Click(sender, e);
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            buttonAdd_Click(sender, e);
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            buttonEdit_Click(sender, e);
        }

        private void toolStripFilter_Click(object sender, EventArgs e)
        {
            buttonFilter_Click(sender, e);
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            buttonDeleteAll_Click(sender, e);
        }

        private void toolStripDropDownButtonFile_Click(object sender, EventArgs e)
        {
            if (tableList.RowCount == 0)
            {
                toolStripEdit.Enabled = false;
                toolStripFilter.Enabled = false;
                toolStripDelete.Enabled = false;
            }
            else
            {
                toolStripEdit.Enabled = true;
                toolStripFilter.Enabled = true;
                toolStripDelete.Enabled = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            tableList.DefaultCellStyle.Font = fontDialog1.Font;
            tableList.ColumnHeadersDefaultCellStyle.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            tableList.DefaultCellStyle.ForeColor = colorDialog1.Color;
            tableList.ColumnHeadersDefaultCellStyle.ForeColor = colorDialog1.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsSaved)
            {
                MessageForm mes = new MessageForm(this);
                IsSaved = true;
            }
            Close();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            if (!IsSaved) label1.Text = "CarViewer*";
            if (IsSaved) label1.Text = "CarViewer";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsSaved)
            {
                MessageForm mes = new MessageForm(this);
                mes.ShowDialog();
            }
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            if (!IsSaved) label1.Text = "CarViewer*";
            if (IsSaved)  label1.Text = "CarViewer";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}
