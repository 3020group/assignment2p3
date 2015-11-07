using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmetnt3q3
{
    public partial class mainView : Form
    {
        public mainView()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitTool_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteTool_Click(object sender, EventArgs e)
        {

        }

        private void editTool_Click(object sender, EventArgs e)
        {

        }

        private void aboutTool_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //the new client button
        private void button1_Click(object sender, EventArgs e)
        {
            newContact newForm = new newContact();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
