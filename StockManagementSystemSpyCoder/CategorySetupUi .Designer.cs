namespace StockManagementSystemSpyCoder
{
    partial class CategorySetupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.categorySetupSaveButton = new System.Windows.Forms.Button();
            this.categorySetupNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // categorySetupSaveButton
            // 
            this.categorySetupSaveButton.Location = new System.Drawing.Point(166, 104);
            this.categorySetupSaveButton.Name = "categorySetupSaveButton";
            this.categorySetupSaveButton.Size = new System.Drawing.Size(75, 23);
            this.categorySetupSaveButton.TabIndex = 1;
            this.categorySetupSaveButton.Text = "Save";
            this.categorySetupSaveButton.UseVisualStyleBackColor = true;
            this.categorySetupSaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categorySetupNameTextBox
            // 
            this.categorySetupNameTextBox.Location = new System.Drawing.Point(141, 36);
            this.categorySetupNameTextBox.Name = "categorySetupNameTextBox";
            this.categorySetupNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.categorySetupNameTextBox.TabIndex = 2;
            // 
            // CategorySetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.categorySetupNameTextBox);
            this.Controls.Add(this.categorySetupSaveButton);
            this.Controls.Add(this.label1);
            this.Name = "CategorySetupForm";
            this.Text = "Category Setup ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button categorySetupSaveButton;
        private System.Windows.Forms.TextBox categorySetupNameTextBox;
    }
}

