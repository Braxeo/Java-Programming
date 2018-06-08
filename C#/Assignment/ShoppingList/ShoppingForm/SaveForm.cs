using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace ShoppingForm
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }
        public SaveForm(ShoppingListObj.ShoppingList list)
        {
            InitializeComponent();
            this.list = list;
        }

        // Save button clicked
        private void button2_Click(object sender, EventArgs e)
        {
            // XML Serialization to save to XML file
            XmlSerializer serial = new XmlSerializer(typeof(List<string>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + textBox1.Text + ".xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, list.GetList());
                MessageBox.Show("Created");
                this.Close();
            }
        }
        
    }
}
