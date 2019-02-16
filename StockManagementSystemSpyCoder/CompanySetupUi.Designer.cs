namespace StockManagementSystemSpyCoder
{
    partial class CompanySetupUi
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
            this.companySetupNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanySetupSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.companySetupDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companySetupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companySetupNameTextBox
            // 
            this.companySetupNameTextBox.Location = new System.Drawing.Point(202, 43);
            this.companySetupNameTextBox.Name = "companySetupNameTextBox";
            this.companySetupNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.companySetupNameTextBox.TabIndex = 5;
            // 
            // CompanySetupSaveButton
            // 
            this.CompanySetupSaveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CompanySetupSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompanySetupSaveButton.ForeColor = System.Drawing.Color.White;
            this.CompanySetupSaveButton.Location = new System.Drawing.Point(385, 91);
            this.CompanySetupSaveButton.Name = "CompanySetupSaveButton";
            this.CompanySetupSaveButton.Size = new System.Drawing.Size(95, 29);
            this.CompanySetupSaveButton.TabIndex = 4;
            this.CompanySetupSaveButton.Text = "Save";
            this.CompanySetupSaveButton.UseVisualStyleBackColor = false;
            this.CompanySetupSaveButton.Click += new System.EventHandler(this.CompanySetupSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 10);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(-9, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 10);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(0, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 341);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(541, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 389);
            this.panel4.TabIndex = 9;
            // 
            // companySetupDataGridView
            // 
            this.companySetupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companySetupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.companySetupDataGridView.GridColor = System.Drawing.Color.White;
            this.companySetupDataGridView.Location = new System.Drawing.Point(70, 177);
            this.companySetupDataGridView.Name = "companySetupDataGridView";
            this.companySetupDataGridView.RowHeadersWidth = 31;
            this.companySetupDataGridView.Size = new System.Drawing.Size(410, 58);
            this.companySetupDataGridView.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 380;
            // 
            // CompanySetupUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 353);
            this.Controls.Add(this.companySetupDataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.companySetupNameTextBox);
            this.Controls.Add(this.CompanySetupSaveButton);
            this.Controls.Add(this.label1);
            this.Name = "CompanySetupUi";
            this.Text = "CompanySetupUi";
            ((System.ComponentModel.ISupportInitialize)(this.companySetupDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox companySetupNameTextBox;
        private System.Windows.Forms.Button CompanySetupSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView companySetupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}