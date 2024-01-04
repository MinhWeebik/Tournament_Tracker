namespace TrackerUI
{
    partial class SelectDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDatabaseForm));
            this.databaseCombobox = new System.Windows.Forms.ComboBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.selectFilePathButton = new System.Windows.Forms.Button();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // databaseCombobox
            // 
            this.databaseCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.databaseCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseCombobox.ForeColor = System.Drawing.Color.DarkGreen;
            this.databaseCombobox.FormattingEnabled = true;
            this.databaseCombobox.Location = new System.Drawing.Point(68, 96);
            this.databaseCombobox.Name = "databaseCombobox";
            this.databaseCombobox.Size = new System.Drawing.Size(243, 38);
            this.databaseCombobox.TabIndex = 0;
            this.databaseCombobox.SelectedIndexChanged += new System.EventHandler(this.databaseCombobox_SelectedIndexChanged);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.headerLabel.Location = new System.Drawing.Point(37, 22);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(314, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Chọn cở sở dữ liệu";
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.selectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.selectButton.Location = new System.Drawing.Point(68, 140);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(243, 42);
            this.selectButton.TabIndex = 14;
            this.selectButton.Text = "Chọn CSDL";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            this.selectButton.MouseEnter += new System.EventHandler(this.selectButton_MouseEnter);
            this.selectButton.MouseLeave += new System.EventHandler(this.selectButton_MouseLeave);
            // 
            // selectFilePathButton
            // 
            this.selectFilePathButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectFilePathButton.Enabled = false;
            this.selectFilePathButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectFilePathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.selectFilePathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectFilePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFilePathButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFilePathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.selectFilePathButton.Location = new System.Drawing.Point(68, 188);
            this.selectFilePathButton.Name = "selectFilePathButton";
            this.selectFilePathButton.Size = new System.Drawing.Size(243, 42);
            this.selectFilePathButton.TabIndex = 15;
            this.selectFilePathButton.Text = "Chọn địa điểm lưu";
            this.selectFilePathButton.UseVisualStyleBackColor = false;
            this.selectFilePathButton.Click += new System.EventHandler(this.selectFilePathButton_Click);
            this.selectFilePathButton.MouseEnter += new System.EventHandler(this.selectFilePathButton_MouseEnter);
            this.selectFilePathButton.MouseLeave += new System.EventHandler(this.selectFilePathButton_MouseLeave);
            // 
            // filePathText
            // 
            this.filePathText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filePathText.Enabled = false;
            this.filePathText.ForeColor = System.Drawing.Color.DarkGreen;
            this.filePathText.Location = new System.Drawing.Point(68, 262);
            this.filePathText.Name = "filePathText";
            this.filePathText.ReadOnly = true;
            this.filePathText.Size = new System.Drawing.Size(243, 35);
            this.filePathText.TabIndex = 17;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filePathLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.filePathLabel.Location = new System.Drawing.Point(69, 233);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(242, 25);
            this.filePathLabel.TabIndex = 18;
            this.filePathLabel.Text = "Địa điểm lưu file hiện tại là:";
            // 
            // SelectDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(383, 337);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.selectFilePathButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.databaseCombobox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SelectDatabaseForm";
            this.Text = "Chọn cơ sở dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox databaseCombobox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button selectFilePathButton;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Label filePathLabel;
    }
}