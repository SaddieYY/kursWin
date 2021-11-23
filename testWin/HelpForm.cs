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
    //клас HelpForm - для вікна "Допомога"
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            BackColor = ColorElem.BackColor;
            button1.BackColor = ColorElem.ButtonBackColor;
            button1.ForeColor = ColorElem.ButtonForeColor;
            textBoxHelp.BackColor = ColorElem.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
