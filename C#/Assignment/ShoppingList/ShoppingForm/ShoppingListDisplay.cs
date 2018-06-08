using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace ShoppingForm
{
    public partial class ShoppingListDisplay : Form
    {
        public ShoppingListDisplay()
        {
            InitializeComponent();
            shoppinglist = new ShoppingListObj.ShoppingList();
            
            // Adding methods to Event variables
            CheckItem += OnItemInput;
            MouseCheck += onMouseMovement;
        }

        // Click Events
        private void button2_Click(object sender, EventArgs e)
        {
            shoppinglist.RemoveItem(textBox1.Text);
            ListUpdate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (CheckItem(this, new CharCheckEventArgs { item_name = textBox1.Text}))
                {
                    shoppinglist.Add(textBox1.Text);
                }else
                {
                    MessageBox.Show("Alphabet only please!");
                }
            }
            ListUpdate();
            textBox1.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            shoppinglist.ClearList();
            ListUpdate();
        }
        private void saveF12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
        private void loadF11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }
        // Mouse Events
        private void ShoppingListDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // Comment out this statement to stop background Color changing
            // if it gets annoying.
            this.BackColor = MouseCheck(this, new ColorArgs { color = this.BackColor });
        }

        // "Keyboard shortcuts" for Save, Load and Exit
        private void ShoppingListDisplay_KeyUp(object sender, KeyEventArgs e)
        {
            if (shoppinglist != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        {
                            this.Close();
                        }
                        break;
                    case Keys.F12:
                        {
                            SaveToFile();
                        }
                        break;
                    case Keys.F11:
                        {
                            LoadFromFile();
                        }
                        break;
                    default:
                        break;
                }
                ListUpdate();
            }
            
        }
        
        // Calls Saveform to save to xml file
        private void SaveToFile()
        {
            SaveForm form = new SaveForm(shoppinglist);
            form.Show(this);
        }
        // Calls Loadform to load existing shopping list
        private void LoadFromFile()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "XML Files|*.xml",
                Title = "Select a XML file"
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlSerializer serial = new XmlSerializer(typeof(List<string>));
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    shoppinglist.setList(serial.Deserialize(fs) as List<string>);
                    ListUpdate();
                }

            }
        }
        // Method used to update the list
        private void ListUpdate()
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = shoppinglist.GetList();
        }

        // Event 1 Definition
        static bool OnItemInput(object sender, CharCheckEventArgs args)
        {
            return args.item_name.All(x => char.IsLetter(x));
        }
        // Event 2 Definition
        static System.Drawing.Color onMouseMovement(object sender, ColorArgs args)
        {
            return System.Drawing.Color.FromArgb(args.color.ToArgb() + 1);
        }
        

        
    }
}
