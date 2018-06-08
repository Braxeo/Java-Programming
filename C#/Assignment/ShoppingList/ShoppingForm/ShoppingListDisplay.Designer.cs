
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(93, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 147);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveF12ToolStripMenuItem,
            this.loadF11ToolStripMenuItem,
            this.exitEscToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // saveF12ToolStripMenuItem
            // 
            this.saveF12ToolStripMenuItem.Name = "saveF12ToolStripMenuItem";
            this.saveF12ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveF12ToolStripMenuItem.Text = "Save(F12)";
            this.saveF12ToolStripMenuItem.Click += new System.EventHandler(this.saveF12ToolStripMenuItem_Click);
            // 
            // loadF11ToolStripMenuItem
            // 
            this.loadF11ToolStripMenuItem.Name = "loadF11ToolStripMenuItem";
            this.loadF11ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadF11ToolStripMenuItem.Text = "Load(F11)";
            this.loadF11ToolStripMenuItem.Click += new System.EventHandler(this.loadF11ToolStripMenuItem_Click);
            // 
            // exitEscToolStripMenuItem
            // 
            this.exitEscToolStripMenuItem.Name = "exitEscToolStripMenuItem";
            this.exitEscToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitEscToolStripMenuItem.Text = "Exit(Esc)";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "A button named Add";
            this.button1.AccessibleName = "Add";
            this.button1.Location = new System.Drawing.Point(224, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current List";
            // 
            // ShoppingListDisplay
            // 
            this.AcceptButton = this.button1;
            this.AccessibleDescription = "Shopping List Application";
            this.AccessibleName = "ShoppingList";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 424);
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
    }

}