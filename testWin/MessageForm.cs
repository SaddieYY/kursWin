using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursWin
{
    //клас MessageForm - для вікна "Повідомлення"
    public partial class MessageForm : Form
    {
        private MainForm parent;
        public MessageForm()
        {
            InitializeComponent();
        }
        public MessageForm(MainForm p)
        {
            InitializeComponent();
            parent = p;
            BackColor = ColorElem.BackColor;

            buttonSave.BackColor = ColorElem.ButtonBackColor;
            buttonSave.ForeColor = ColorElem.ButtonForeColor;

            buttonNo.BackColor = ColorElem.ButtonBackColor;
            buttonNo.ForeColor = ColorElem.ButtonForeColor;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            parent.IsSaved = true;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            parent.buttonSaveAs_Click(sender, e);
            Close();
        }
    }
}
