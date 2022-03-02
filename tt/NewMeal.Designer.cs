namespace tt
{
    partial class NewMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMeal));
            this.lblEnterNewMealName = new System.Windows.Forms.Label();
            this.lblPriceofMeal = new System.Windows.Forms.Label();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.txtPriceofMeal = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterNewMealName
            // 
            this.lblEnterNewMealName.AutoSize = true;
            this.lblEnterNewMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNewMealName.Location = new System.Drawing.Point(12, 36);
            this.lblEnterNewMealName.Name = "lblEnterNewMealName";
            this.lblEnterNewMealName.Size = new System.Drawing.Size(167, 20);
            this.lblEnterNewMealName.TabIndex = 0;
            this.lblEnterNewMealName.Text = "Enter New Meal Name";
            // 
            // lblPriceofMeal
            // 
            this.lblPriceofMeal.AutoSize = true;
            this.lblPriceofMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceofMeal.Location = new System.Drawing.Point(79, 91);
            this.lblPriceofMeal.Name = "lblPriceofMeal";
            this.lblPriceofMeal.Size = new System.Drawing.Size(100, 20);
            this.lblPriceofMeal.TabIndex = 1;
            this.lblPriceofMeal.Text = "Price of Meal";
            // 
            // txtMealName
            // 
            this.txtMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealName.Location = new System.Drawing.Point(214, 30);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(236, 26);
            this.txtMealName.TabIndex = 2;
            // 
            // txtPriceofMeal
            // 
            this.txtPriceofMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceofMeal.Location = new System.Drawing.Point(214, 85);
            this.txtPriceofMeal.Name = "txtPriceofMeal";
            this.txtPriceofMeal.Size = new System.Drawing.Size(236, 26);
            this.txtPriceofMeal.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(332, 126);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NewMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 161);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPriceofMeal);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.lblPriceofMeal);
            this.Controls.Add(this.lblEnterNewMealName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMeal";
            this.Text = "New Meal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNewMealName;
        private System.Windows.Forms.Label lblPriceofMeal;
        private System.Windows.Forms.TextBox txtMealName;
        private System.Windows.Forms.TextBox txtPriceofMeal;
        private System.Windows.Forms.Button btnOK;
    }
}