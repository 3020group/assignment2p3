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

namespace assignmetnt3q3
{
    public partial class newContact : Form
    {
        private mainView masterForm;

        public newContact(mainView masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode elem;
            String path = @"./a2entries.xml";
            doc.Load(path);
            XmlNode node = doc.CreateNode(XmlNodeType.Element,"entry",null);

            elem = doc.CreateElement("firstName");
            elem.InnerText = firstNameBox.Text;
            node.AppendChild(elem);

            elem = doc.CreateElement("lastName");
            elem.InnerText = lastNameBox.Text;
            node.AppendChild(elem);

            elem = doc.CreateElement("age");
            elem.InnerText = textBox1.Text;
            node.AppendChild(elem);
            
            elem = doc.CreateElement("gender");
            elem.InnerText = genderCombo.Text;
            node.AppendChild(elem);

            elem = doc.CreateElement("year");
            elem.InnerText = yearCombo.Text;
            node.AppendChild(elem);

            elem = doc.CreateElement("phone");
            elem.InnerText = textBox2.Text;
            node.AppendChild(elem);

            elem = doc.CreateElement("address");
            elem.InnerText = textBox3.Text;
            node.AppendChild(elem);

            doc.DocumentElement.AppendChild(node);
            doc.Save(path);
            masterForm.populateList();
            Close();
        }
    }
}
