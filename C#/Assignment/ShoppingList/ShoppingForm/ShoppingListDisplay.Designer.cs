
namespace ShoppingForm
{
    partial class ShoppingListDisplay
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            Microsoft.Win32.SystemEvents.UserPreferenceChanged 
                -= new Microsoft.Win32.UserPreferenceChangedEventHandler(this.UserPreferenceChanged);

            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveF12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadF11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitEscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ToggleEvent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AccessibleDescription = "A list that displays your shopping list";
            this.listBox1.AccessibleName = "ListBox";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(93, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 132);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "An input field for shopping items";
            this.textBox1.AccessibleName = "Input Field";
            this.textBox1.Location = new System.Drawing.Point(93, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.AccessibleDescription = "Menu Strip named \'File\' with a drop down menu";
            this.saveToolStripMenuItem.AccessibleName = "File";
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveF12ToolStripMenuItem,
            this.loadF11ToolStripMenuItem,
            this.exitEscToolStripMenuItem});
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.saveToolStripMenuItem.Text = "&File";
            // 
            // saveF12ToolStripMenuItem
            // 
            this.saveF12ToolStripMenuItem.AccessibleDescription = "Menu Strip Item named \'Save\'";
            this.saveF12ToolStripMenuItem.AccessibleName = "Save";
            this.saveF12ToolStripMenuItem.Name = "saveF12ToolStripMenuItem";
            this.saveF12ToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.saveF12ToolStripMenuItem.Text = "&Save(F12)";
            this.saveF12ToolStripMenuItem.Click += new System.EventHandler(this.saveF12ToolStripMenuItem_Click);
            // 
            // loadF11ToolStripMenuItem
            // 
            this.loadF11ToolStripMenuItem.AccessibleDescription = "Menu Strip Item named \'Load\'";
            this.loadF11ToolStripMenuItem.AccessibleName = "Load";
            this.loadF11ToolStripMenuItem.Name = "loadF11ToolStripMenuItem";
            this.loadF11ToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.loadF11ToolStripMenuItem.Text = "&Load(F11)";
            this.loadF11ToolStripMenuItem.Click += new System.EventHandler(this.loadF11ToolStripMenuItem_Click);
            // 
            // exitEscToolStripMenuItem
            // 
            this.exitEscToolStripMenuItem.AccessibleDescription = "Menu Strip Item named \'Exit\'";
            this.exitEscToolStripMenuItem.AccessibleName = "Exit";
            this.exitEscToolStripMenuItem.Name = "exitEscToolStripMenuItem";
            this.exitEscToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.exitEscToolStripMenuItem.Text = "&Exit(Esc)";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "A button named \'Add\'";
            this.button1.AccessibleName = "Add";
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "A button named \'Remove\'";
            this.button2.AccessibleName = "Remove";
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(93, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.AccessibleDescription = "A button called \'Clear\'";
            this.button4.AccessibleName = "Clear";
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(93, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "&Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Text saying \'Current List\'";
            this.label1.AccessibleName = "Label";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Current List";
            // 
            // ToggleEvent
            // 
            this.ToggleEvent.AccessibleDescription = "Button that says \'Event 2 Toggle\'";
            this.ToggleEvent.AccessibleName = "ToggleEvent";
            this.ToggleEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleEvent.Location = new System.Drawing.Point(149, 379);
            this.ToggleEvent.Name = "ToggleEvent";
            this.ToggleEvent.Size = new System.Drawing.Size(119, 33);
            this.ToggleEvent.TabIndex = 7;
            this.ToggleEvent.Text = "&Event 2 Toggle";
            this.ToggleEvent.UseVisualStyleBackColor = true;
            this.ToggleEvent.Click += new System.EventHandler(this.ToggleEvent_Click);
            // 
            // ShoppingListDisplay
            // 
            this.AcceptButton = this.button1;
            this.AccessibleDescription = "Shopping List Application";
            this.AccessibleName = "ShoppingList";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 424);
            this.Controls.Add(this.ToggleEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShoppingListDisplay";
            this.Text = "ShoppingListDisplay";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShoppingListDisplay_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShoppingListDisplay_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 2 Events 
        public event CharCheckDelegate CheckItem;
        public event MouseCheck MouseCheck;
        public bool EnableEvent;

        // Shopping List object
        private ShoppingListObj.ShoppingList shoppinglist;

        // Form Controls
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem saveF12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadF11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitEscToolStripMenuItem;
        private System.Windows.Forms.Button ToggleEvent;
    }

}