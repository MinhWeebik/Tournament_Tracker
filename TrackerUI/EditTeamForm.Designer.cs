namespace TrackerUI
{
    partial class EditTeamForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeamForm));
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.updateTeamButton = new System.Windows.Forms.Button();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addNewNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.teamMemberToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addNewNumberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(30, 706);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(144, 21);
            this.emailErrorLabel.TabIndex = 40;
            this.emailErrorLabel.Text = "Email không hợp lệ";
            this.emailErrorLabel.Visible = false;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(436, 608);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(262, 21);
            this.errorMessageLabel.TabIndex = 39;
            this.errorMessageLabel.Text = "Cần ít nhất một thành viên trong đội";
            this.errorMessageLabel.Visible = false;
            // 
            // updateTeamButton
            // 
            this.updateTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.updateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.updateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.updateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.updateTeamButton.Location = new System.Drawing.Point(208, 728);
            this.updateTeamButton.Name = "updateTeamButton";
            this.updateTeamButton.Size = new System.Drawing.Size(233, 70);
            this.updateTeamButton.TabIndex = 38;
            this.updateTeamButton.Text = "Sửa đội";
            this.updateTeamButton.UseVisualStyleBackColor = false;
            this.updateTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            this.updateTeamButton.MouseEnter += new System.EventHandler(this.updateTeamButton_MouseEnter);
            this.updateTeamButton.MouseLeave += new System.EventHandler(this.updateTeamButton_MouseLeave);
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(797, 377);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(131, 75);
            this.deleteSelectedMemberButton.TabIndex = 37;
            this.deleteSelectedMemberButton.Text = "Xóa cái được chọn";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = false;
            this.deleteSelectedMemberButton.Click += new System.EventHandler(this.deleteSelectedMemberButton_Click);
            this.deleteSelectedMemberButton.MouseEnter += new System.EventHandler(this.deleteSelectedMemberButton_MouseEnter);
            this.deleteSelectedMemberButton.MouseLeave += new System.EventHandler(this.deleteSelectedMemberButton_MouseLeave);
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(440, 123);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(337, 482);
            this.teamMembersListBox.TabIndex = 36;
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.createMemberButton.Location = new System.Drawing.Point(73, 289);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(210, 45);
            this.createMemberButton.TabIndex = 20;
            this.createMemberButton.Text = "Tạo thành viên";
            this.createMemberButton.UseVisualStyleBackColor = false;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            this.createMemberButton.MouseEnter += new System.EventHandler(this.createMemberButton_MouseEnter);
            this.createMemberButton.MouseLeave += new System.EventHandler(this.createMemberButton_MouseLeave);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cellphoneValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.cellphoneValue.Location = new System.Drawing.Point(132, 229);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(187, 43);
            this.cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.cellphoneLabel.Location = new System.Drawing.Point(12, 226);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(67, 38);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "SĐT";
            // 
            // emailValue
            // 
            this.emailValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emailValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.emailValue.Location = new System.Drawing.Point(132, 169);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(187, 43);
            this.emailValue.TabIndex = 14;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectTeamMemberDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTeamMemberDropDown.ForeColor = System.Drawing.Color.DarkGreen;
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(34, 218);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(349, 38);
            this.selectTeamMemberDropDown.TabIndex = 33;
            this.teamMemberToolTip.SetToolTip(this.selectTeamMemberDropDown, "Tên thành viên - 4 số cuối SĐT");
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(27, 173);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(220, 38);
            this.selectTeamMemberLabel.TabIndex = 32;
            this.selectTeamMemberLabel.Text = "Chọn thành viên";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.emailLabel.Location = new System.Drawing.Point(12, 166);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(83, 38);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lastNameValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lastNameValue.Location = new System.Drawing.Point(132, 109);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(187, 43);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.lastNameLabel.Location = new System.Drawing.Point(12, 106);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(53, 38);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Họ";
            // 
            // firstNameValue
            // 
            this.firstNameValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.firstNameValue.Location = new System.Drawing.Point(132, 49);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(187, 43);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.firstNameLabel.Location = new System.Drawing.Point(12, 46);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(114, 38);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "Tên đầu";
            // 
            // addNewNumberGroupBox
            // 
            this.addNewNumberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewNumberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewNumberGroupBox.Controls.Add(this.cellphoneLabel);
            this.addNewNumberGroupBox.Controls.Add(this.emailValue);
            this.addNewNumberGroupBox.Controls.Add(this.emailLabel);
            this.addNewNumberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewNumberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewNumberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewNumberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewNumberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewNumberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.addNewNumberGroupBox.Location = new System.Drawing.Point(34, 346);
            this.addNewNumberGroupBox.Name = "addNewNumberGroupBox";
            this.addNewNumberGroupBox.Size = new System.Drawing.Size(349, 357);
            this.addNewNumberGroupBox.TabIndex = 35;
            this.addNewNumberGroupBox.TabStop = false;
            this.addNewNumberGroupBox.Text = "Tạo thành viên";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.addMemberButton.Location = new System.Drawing.Point(107, 278);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(210, 45);
            this.addMemberButton.TabIndex = 34;
            this.addMemberButton.Text = "Thêm thành viên";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            this.addMemberButton.MouseEnter += new System.EventHandler(this.addMemberButton_MouseEnter);
            this.addMemberButton.MouseLeave += new System.EventHandler(this.addMemberButton_MouseLeave);
            // 
            // teamNameValue
            // 
            this.teamNameValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.teamNameValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.teamNameValue.Location = new System.Drawing.Point(34, 123);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(349, 36);
            this.teamNameValue.TabIndex = 31;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.teamNameLabel.Location = new System.Drawing.Point(27, 82);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(107, 38);
            this.teamNameLabel.TabIndex = 30;
            this.teamNameLabel.Text = "Tên đội";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.headerLabel.Location = new System.Drawing.Point(25, 22);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(138, 50);
            this.headerLabel.TabIndex = 29;
            this.headerLabel.Text = "Sửa đội";
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.deleteTeamButton.Location = new System.Drawing.Point(494, 728);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(233, 70);
            this.deleteTeamButton.TabIndex = 41;
            this.deleteTeamButton.Text = "Xóa đội";
            this.deleteTeamButton.UseVisualStyleBackColor = false;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click_1);
            this.deleteTeamButton.MouseEnter += new System.EventHandler(this.deleteTeamButton_MouseEnter);
            this.deleteTeamButton.MouseLeave += new System.EventHandler(this.deleteTeamButton_MouseLeave);
            // 
            // searchValue
            // 
            this.searchValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.searchValue.Location = new System.Drawing.Point(440, 62);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(337, 36);
            this.searchValue.TabIndex = 42;
            this.searchValue.TextChanged += new System.EventHandler(this.searchValue_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(114)))));
            this.searchLabel.Location = new System.Drawing.Point(433, 21);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(131, 38);
            this.searchLabel.TabIndex = 43;
            this.searchLabel.Text = "Tìm kiếm";
            // 
            // EditTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(948, 820);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.updateTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.addNewNumberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditTeamForm";
            this.Text = "Sửa thông tin đội";
            this.addNewNumberGroupBox.ResumeLayout(false);
            this.addNewNumberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button updateTeamButton;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox addNewNumberGroupBox;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ToolTip teamMemberToolTip;
    }
}