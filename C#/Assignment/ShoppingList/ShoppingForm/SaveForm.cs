using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;

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
            
            // Adjust to HighContrast if needed
            SetColorScheme();
            Microsoft.Win32.SystemEvents.UserPreferenceChanged
                += new Microsoft.Win32.UserPreferenceChangedEventHandler(this.UserPreferenceChanged);

            this.list = list;
        }

        // High Contrast Event
        public void UserPreferenceChanged(object sender, Microsoft.Win32.UserPreferenceChangedEventArgs args)
        {
            SetColorScheme();
        }

        // HighContrast Color Scheme
        private void SetColorScheme()
        {
            if (System.Windows.Forms.SystemInformation.HighContrast)
            {
                this.BackColor = SystemColors.Window;
                this.ForeColor = SystemColors.WindowText;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
