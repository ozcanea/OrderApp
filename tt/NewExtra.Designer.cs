namespace tt
{
    partial class NewExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewExtra));
            this.btnOKExtra = new System.Windows.Forms.Button();
            this.txtPriceofExtra = new System.Windows.Forms.TextBox();
            this.txtExtraName = new System.Windows.Forms.TextBox();
            this.lblPriceOfExtra = new System.Windows.Forms.Label();
            this.lblEnterNewMealName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOKExtra
            // 
            this.btnOKExtra.Location = new System.Drawing.Point(355, 113);
            this.btnOKExtra.Name = "btnOKExtra";
            this.btnOKExtra.Size = new System.Drawing.Size(118, 30);
            this.btnOKExtra.TabIndex = 9;
            this.btnOKExtra.Text = "OK";
            this.btnOKExtra.UseVisualStyleBackColor = true;
            this.btnOKExtra.Click += new System.EventHandler(this.btnOKExtra_Click);
            // 
            // txtPriceofExtra
            // 
            this.txtPriceofExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceofExtra.Location = new System.Drawing.Point(237, 72);
            this.txtPriceofExtra.Name = "txtPriceofExtra";
            this.txtPriceofExtra.Size = new System.Drawing.Size(236, 26);
            this.txtPriceofExtra.TabIndex = 8;
            // 
            // txtExtraName
            // 
            this.txtExtraName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraName.Location = new System.Drawing.Point(237, 17);
            this.txtExtraName.Name = "txtExtraName";
            this.txtExtraName.Size = new System.Drawing.Size(236, 26);
            this.txtExtraName.TabIndex = 7;
            // 
            // lblPriceOfExtra
            // 
            this.lblPriceOfExtra.AutoSize = true;
            this.lblPriceOfExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceOfExtra.Location = new System.Drawing.Point(102, 78);
            this.lblPriceOfExtra.Name = "lblPriceOfExtra";
            this.lblPriceOfExtra.Size = new System.Drawing.Size(115, 20);
            this.lblPriceOfExtra.TabIndex = 6;
            this.lblPriceOfExtra.Text = "Price Of Sauce";
            // 
            // lblEnterNewMealName
            // 
            this.lblEnterNewMealName.AutoSize = true;
            this.lblEnterNewMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNewMealName.Location = new System.Drawing.Point(35, 23);
            this.lblEnterNewMealName.Name = "lblEnterNewMealName";
            this.lblEnterNewMealName.Size = new System.Drawing.Size(179, 20);
            this.lblEnterNewMealName.TabIndex = 5;
            this.lblEnterNewMealName.Text = "Enter New Sauce Name";
            // 
            // NewExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 161);
            this.Controls.Add(this.btnOKExtra);
            this.Controls.Add(this.txtPriceofExtra);
            this.Controls.Add(this.txtExtraName);
            this.Controls.Add(this.lblPriceOfExtra);
            this.Controls.Add(this.lblEnterNewMealName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewExtra";
            this.Text = "NewExtra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOKExtra;
        private System.Windows.Forms.TextBox txtPriceofExtra;
        private System.Windows.Forms.TextBox txtExtraName;
        private System.Windows.Forms.Label lblPriceOfExtra;
        private System.Windows.Forms.Label lblEnterNewMealName;
    }
}