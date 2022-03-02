namespace tt
{
    partial class MDIParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSiparisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sosEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endorsementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisToolStripMenuItem,
            this.yeniToolStripMenuItem,
            this.endorsementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisToolStripMenuItem
            // 
            this.siparisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSiparisToolStripMenuItem});
            this.siparisToolStripMenuItem.Name = "siparisToolStripMenuItem";
            this.siparisToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.siparisToolStripMenuItem.Text = "Order";
            // 
            // yeniSiparisToolStripMenuItem
            // 
            this.yeniSiparisToolStripMenuItem.Name = "yeniSiparisToolStripMenuItem";
            this.yeniSiparisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniSiparisToolStripMenuItem.Text = "New Order";
            this.yeniSiparisToolStripMenuItem.Click += new System.EventHandler(this.yeniSiparisToolStripMenuItem_Click_1);
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEkleToolStripMenuItem,
            this.sosEkleToolStripMenuItem});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.yeniToolStripMenuItem.Text = "New";
            // 
            // menuEkleToolStripMenuItem
            // 
            this.menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            this.menuEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuEkleToolStripMenuItem.Text = "Add New Meal";
            this.menuEkleToolStripMenuItem.Click += new System.EventHandler(this.menuEkleToolStripMenuItem_Click);
            // 
            // sosEkleToolStripMenuItem
            // 
            this.sosEkleToolStripMenuItem.Name = "sosEkleToolStripMenuItem";
            this.sosEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sosEkleToolStripMenuItem.Text = "Add Extra";
            this.sosEkleToolStripMenuItem.Click += new System.EventHandler(this.sosEkleToolStripMenuItem_Click_1);
            // 
            // endorsementToolStripMenuItem
            // 
            this.endorsementToolStripMenuItem.Name = "endorsementToolStripMenuItem";
            this.endorsementToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.endorsementToolStripMenuItem.Text = "Endorsement";
            this.endorsementToolStripMenuItem.Click += new System.EventHandler(this.endorsementToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 451);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent";
            this.Text = "Welcome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSiparisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sosEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endorsementToolStripMenuItem;
    }
}