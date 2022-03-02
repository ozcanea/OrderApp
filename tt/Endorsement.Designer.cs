namespace tt
{
    partial class Endorsement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Endorsement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lBOrderList = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lBOrderDate = new System.Windows.Forms.ListBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEndorsementTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEndorsementTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hScrollBar3);
            this.panel1.Controls.Add(this.hScrollBar2);
            this.panel1.Controls.Add(this.vScrollBar2);
            this.panel1.Controls.Add(this.lBOrderDate);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.lBOrderList);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 423);
            this.panel1.TabIndex = 3;
            // 
            // lBOrderList
            // 
            this.lBOrderList.FormattingEnabled = true;
            this.lBOrderList.Location = new System.Drawing.Point(13, 13);
            this.lBOrderList.Name = "lBOrderList";
            this.lBOrderList.Size = new System.Drawing.Size(558, 342);
            this.lBOrderList.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(554, 7);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 332);
            this.vScrollBar1.TabIndex = 1;
            // 
            // lBOrderDate
            // 
            this.lBOrderDate.FormattingEnabled = true;
            this.lBOrderDate.Location = new System.Drawing.Point(594, 13);
            this.lBOrderDate.Name = "lBOrderDate";
            this.lBOrderDate.Size = new System.Drawing.Size(194, 342);
            this.lBOrderDate.TabIndex = 2;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(771, 16);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 323);
            this.vScrollBar2.TabIndex = 3;
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(594, 339);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(194, 16);
            this.hScrollBar2.TabIndex = 5;
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(13, 339);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(558, 16);
            this.hScrollBar3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total =";
            // 
            // lblEndorsementTotal
            // 
            this.lblEndorsementTotal.AutoSize = true;
            this.lblEndorsementTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndorsementTotal.Location = new System.Drawing.Point(485, 380);
            this.lblEndorsementTotal.Name = "lblEndorsementTotal";
            this.lblEndorsementTotal.Size = new System.Drawing.Size(0, 20);
            this.lblEndorsementTotal.TabIndex = 8;
            // 
            // Endorsement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Endorsement";
            this.Text = "Endorsement";
            this.Load += new System.EventHandler(this.Endorsement_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.ListBox lBOrderDate;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox lBOrderList;
        private System.Windows.Forms.Label lblEndorsementTotal;
        private System.Windows.Forms.Label label1;
    }
}