﻿namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayerLabel = new System.Windows.Forms.Label();
            this.deleteSelectedTeamButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizesButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.noTeamsErrorLabel = new System.Windows.Forms.Label();
            this.prizeErrorLabel = new System.Windows.Forms.Label();
            this.editTeamButton = new System.Windows.Forms.Button();
            this.currentlyParticipatingErrorLabel = new System.Windows.Forms.Label();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.headerLabel.Location = new System.Drawing.Point(22, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(214, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Tạo giải đấu";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(24, 84);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(166, 38);
            this.tournamentNameLabel.TabIndex = 4;
            this.tournamentNameLabel.Text = "Tên giải đấu";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tournamentNameValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.tournamentNameValue.Location = new System.Drawing.Point(31, 125);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(300, 35);
            this.tournamentNameValue.TabIndex = 9;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.entryFeeValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.entryFeeValue.Location = new System.Drawing.Point(202, 189);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(129, 35);
            this.entryFeeValue.TabIndex = 11;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.entryFeeLabel.Location = new System.Drawing.Point(24, 185);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(172, 38);
            this.entryFeeLabel.TabIndex = 10;
            this.entryFeeLabel.Text = "Phí tham gia";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectTeamDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTeamDropDown.ForeColor = System.Drawing.Color.DarkGreen;
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(31, 293);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(300, 38);
            this.selectTeamDropDown.TabIndex = 13;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.selectTeamLabel.Location = new System.Drawing.Point(24, 248);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(129, 38);
            this.selectTeamLabel.TabIndex = 12;
            this.selectTeamLabel.Text = "Chọn đội";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.LinkColor = System.Drawing.Color.DarkGreen;
            this.createNewTeamLink.Location = new System.Drawing.Point(242, 255);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(89, 30);
            this.createNewTeamLink.TabIndex = 14;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Tạo mới";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addTeamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.addTeamButton.Location = new System.Drawing.Point(51, 426);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(119, 45);
            this.addTeamButton.TabIndex = 15;
            this.addTeamButton.Text = "Thêm đội";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            this.addTeamButton.MouseEnter += new System.EventHandler(this.addTeamButton_MouseEnter);
            this.addTeamButton.MouseLeave += new System.EventHandler(this.addTeamButton_MouseLeave);
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
            this.createPrizeButton.Location = new System.Drawing.Point(76, 504);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(210, 45);
            this.createPrizeButton.TabIndex = 16;
            this.createPrizeButton.Text = "Tạo giải thưởng";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            this.createPrizeButton.MouseEnter += new System.EventHandler(this.createPrizeButton_MouseEnter);
            this.createPrizeButton.MouseLeave += new System.EventHandler(this.createPrizeButton_MouseLeave);
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 30;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(389, 125);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(345, 152);
            this.tournamentTeamsListBox.TabIndex = 17;
            // 
            // tournamentPlayerLabel
            // 
            this.tournamentPlayerLabel.AutoSize = true;
            this.tournamentPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.tournamentPlayerLabel.Location = new System.Drawing.Point(382, 84);
            this.tournamentPlayerLabel.Name = "tournamentPlayerLabel";
            this.tournamentPlayerLabel.Size = new System.Drawing.Size(225, 38);
            this.tournamentPlayerLabel.TabIndex = 18;
            this.tournamentPlayerLabel.Text = "Đội / Người chơi";
            // 
            // deleteSelectedTeamButton
            // 
            this.deleteSelectedTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.deleteSelectedTeamButton.Location = new System.Drawing.Point(755, 402);
            this.deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            this.deleteSelectedTeamButton.Size = new System.Drawing.Size(131, 75);
            this.deleteSelectedTeamButton.TabIndex = 21;
            this.deleteSelectedTeamButton.Text = "Xóa cái được chọn";
            this.deleteSelectedTeamButton.UseVisualStyleBackColor = false;
            this.deleteSelectedTeamButton.Click += new System.EventHandler(this.deleteSelectedTeamButton_Click);
            this.deleteSelectedTeamButton.MouseEnter += new System.EventHandler(this.deleteSelectedTeamButton_MouseEnter);
            this.deleteSelectedTeamButton.MouseLeave += new System.EventHandler(this.deleteSelectedTeamButton_MouseLeave);
            // 
            // deleteSelectedPrizesButton
            // 
            this.deleteSelectedPrizesButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.deleteSelectedPrizesButton.Location = new System.Drawing.Point(755, 164);
            this.deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            this.deleteSelectedPrizesButton.Size = new System.Drawing.Size(131, 75);
            this.deleteSelectedPrizesButton.TabIndex = 24;
            this.deleteSelectedPrizesButton.Text = "Xóa cái được chọn";
            this.deleteSelectedPrizesButton.UseVisualStyleBackColor = false;
            this.deleteSelectedPrizesButton.Click += new System.EventHandler(this.deleteSelectedPrizesButton_Click);
            this.deleteSelectedPrizesButton.MouseEnter += new System.EventHandler(this.deleteSelectedPrizesButton_MouseEnter);
            this.deleteSelectedPrizesButton.MouseLeave += new System.EventHandler(this.deleteSelectedPrizesButton_MouseLeave);
            this.deleteSelectedPrizesButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.deleteSelectedPrizesButton_MouseMove);
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.prizesLabel.Location = new System.Drawing.Point(382, 322);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(177, 38);
            this.prizesLabel.TabIndex = 23;
            this.prizesLabel.Text = "Phần thưởng";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(389, 363);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(345, 152);
            this.prizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.createTournamentButton.Location = new System.Drawing.Point(296, 583);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(233, 70);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Tạo giải đấu";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            this.createTournamentButton.MouseEnter += new System.EventHandler(this.createTournamentButton_MouseEnter);
            this.createTournamentButton.MouseLeave += new System.EventHandler(this.createTournamentButton_MouseLeave);
            // 
            // noTeamsErrorLabel
            // 
            this.noTeamsErrorLabel.AutoSize = true;
            this.noTeamsErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTeamsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.noTeamsErrorLabel.Location = new System.Drawing.Point(594, 280);
            this.noTeamsErrorLabel.Name = "noTeamsErrorLabel";
            this.noTeamsErrorLabel.Size = new System.Drawing.Size(140, 21);
            this.noTeamsErrorLabel.TabIndex = 26;
            this.noTeamsErrorLabel.Text = "Chưa chọn đội nào";
            this.noTeamsErrorLabel.Visible = false;
            // 
            // prizeErrorLabel
            // 
            this.prizeErrorLabel.AutoSize = true;
            this.prizeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.prizeErrorLabel.Location = new System.Drawing.Point(486, 518);
            this.prizeErrorLabel.Name = "prizeErrorLabel";
            this.prizeErrorLabel.Size = new System.Drawing.Size(248, 21);
            this.prizeErrorLabel.TabIndex = 27;
            this.prizeErrorLabel.Text = "Chỉ được tạo tối đa 2 phần thưởng";
            this.prizeErrorLabel.Visible = false;
            // 
            // editTeamButton
            // 
            this.editTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.editTeamButton.Location = new System.Drawing.Point(193, 426);
            this.editTeamButton.Name = "editTeamButton";
            this.editTeamButton.Size = new System.Drawing.Size(119, 45);
            this.editTeamButton.TabIndex = 28;
            this.editTeamButton.Text = "Sửa đội";
            this.editTeamButton.UseVisualStyleBackColor = false;
            this.editTeamButton.Click += new System.EventHandler(this.editTeamButton_Click);
            this.editTeamButton.MouseEnter += new System.EventHandler(this.editTeamButton_MouseEnter);
            this.editTeamButton.MouseLeave += new System.EventHandler(this.editTeamButton_MouseLeave);
            // 
            // currentlyParticipatingErrorLabel
            // 
            this.currentlyParticipatingErrorLabel.AutoSize = true;
            this.currentlyParticipatingErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlyParticipatingErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.currentlyParticipatingErrorLabel.Location = new System.Drawing.Point(47, 471);
            this.currentlyParticipatingErrorLabel.Name = "currentlyParticipatingErrorLabel";
            this.currentlyParticipatingErrorLabel.Size = new System.Drawing.Size(255, 21);
            this.currentlyParticipatingErrorLabel.TabIndex = 29;
            this.currentlyParticipatingErrorLabel.Text = "Đội này đang tham gia vào giải đấu";
            this.currentlyParticipatingErrorLabel.Visible = false;
            // 
            // searchValue
            // 
            this.searchValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.searchValue.Location = new System.Drawing.Point(31, 375);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(300, 35);
            this.searchValue.TabIndex = 30;
            this.searchValue.TextChanged += new System.EventHandler(this.searchValue_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.searchLabel.Location = new System.Drawing.Point(24, 334);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(131, 38);
            this.searchLabel.TabIndex = 31;
            this.searchLabel.Text = "Tìm kiếm";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(919, 692);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.currentlyParticipatingErrorLabel);
            this.Controls.Add(this.editTeamButton);
            this.Controls.Add(this.prizeErrorLabel);
            this.Controls.Add(this.noTeamsErrorLabel);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizesButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedTeamButton);
            this.Controls.Add(this.tournamentPlayerLabel);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Tạo giải đấu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label tournamentPlayerLabel;
        private System.Windows.Forms.Button deleteSelectedTeamButton;
        private System.Windows.Forms.Button deleteSelectedPrizesButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Label noTeamsErrorLabel;
        private System.Windows.Forms.Label prizeErrorLabel;
        private System.Windows.Forms.Button editTeamButton;
        private System.Windows.Forms.Label currentlyParticipatingErrorLabel;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Label searchLabel;
    }
}