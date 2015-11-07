using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace assignmetnt3q3
{
    public partial class mainView : Form
    {
        public mainView()
        {
            InitializeComponent();

            // Making the headers
            listView2.View = View.Details;
            listView2.Columns.Add("First Name", 120, HorizontalAlignment.Left);
            listView2.Columns.Add("Last Name", 120, HorizontalAlignment.Left);
            listView2.Columns.Add("Age", 120, HorizontalAlignment.Left);
            listView2.Columns.Add("Gender", 120, HorizontalAlignment.Left);
            listView2.Columns.Add("Year", 120, HorizontalAlignment.Left);
            listView2.Columns.Add("Phone Number", 120, HorizontalAlignment.Left);
            listView2.Columns.Add("Address", 120, HorizontalAlignment.Left);

            XDocument doc = XDocument.Load("a2entries.xml");

            foreach (var field in doc.Descendants("entries"))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                 field.Element("firstName").Value,
                 field.Element("lastName").Value,
              //   field.Element("instructor").Value,
              //   field.Element("num_students").Value,
                });
                listView2.Items.Add(item);
            }

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
<<<<<<< HEAD
=======

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainView_Load(object sender, EventArgs e)
        {

        }

        private void listView2_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView2.Columns[e.ColumnIndex].Width;
        }
>>>>>>> origin/master
    }
}
