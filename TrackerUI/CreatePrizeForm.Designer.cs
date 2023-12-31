﻿namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.headerLabel.Location = new System.Drawing.Point(23, 24);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(268, 50);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Tạo giải thưởng";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.placeNumberValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.placeNumberValue.Location = new System.Drawing.Point(325, 94);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(187, 35);
            this.placeNumberValue.TabIndex = 13;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.placeNumberLabel.Location = new System.Drawing.Point(25, 91);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(247, 38);
            this.placeNumberLabel.TabIndex = 12;
            this.placeNumberLabel.Text = "Thứ tự giải thưởng";
            // 
            // placeNameValue
            // 
            this.placeNameValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.placeNameValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.placeNameValue.Location = new System.Drawing.Point(325, 152);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(187, 35);
            this.placeNameValue.TabIndex = 15;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.placeNameLabel.Location = new System.Drawing.Point(25, 149);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(142, 38);
            this.placeNameLabel.TabIndex = 14;
            this.placeNameLabel.Text = "Tên thứ tự";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prizeAmountValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.prizeAmountValue.Location = new System.Drawing.Point(325, 210);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(187, 35);
            this.prizeAmountValue.TabIndex = 17;
            this.prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.prizeAmountLabel.Location = new System.Drawing.Point(25, 207);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(241, 38);
            this.prizeAmountLabel.TabIndex = 16;
            this.prizeAmountLabel.Text = "Giá trị giải thưởng";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prizePercentageValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.prizePercentageValue.Location = new System.Drawing.Point(325, 357);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(187, 35);
            this.prizePercentageValue.TabIndex = 19;
            this.prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.prizePercentageLabel.Location = new System.Drawing.Point(25, 354);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(294, 38);
            this.prizePercentageLabel.TabIndex = 18;
            this.prizePercentageLabel.Text = "Phần trăm giải thưởng";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.orLabel.Location = new System.Drawing.Point(229, 281);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(102, 38);
            this.orLabel.TabIndex = 20;
            this.orLabel.Text = "-Hoặc-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.createPrizeButton.Location = new System.Drawing.Point(160, 416);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(233, 70);
            this.createPrizeButton.TabIndex = 27;
            this.createPrizeButton.Text = "Tạo giải thưởng";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            this.createPrizeButton.MouseEnter += new System.EventHandler(this.createPrizeButton_MouseEnter);
            this.createPrizeButton.MouseLeave += new System.EventHandler(this.createPrizeButton_MouseLeave);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(547, 511);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Tạo giải thưởng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}