using newTrackerLibrary;
using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class TournamentDashBoardForm : Form
    {
        
        List<TournamentModel> tournaments = GlobalConfig.Connection.getTournament_All();
        public TournamentDashBoardForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            UsernameTextBox.Text = ConfigurationManager.AppSettings["senderDisplayName"];
            EmailTextBox.Text = ConfigurationManager.AppSettings["senderEmail"];
            WireUp();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            if(ConfigurationManager.AppSettings["senderDisplayName"].Length == 0 || ConfigurationManager.AppSettings["senderEmail"].Length == 0)
            {
                MessageBox.Show("Chưa có thông tin người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateTournamentForm frm = new CreateTournamentForm(this);
                frm.Show();
            }
        }

        private void WireUp()
        {
            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        public void ReWireUp()
        {
            tournaments = GlobalConfig.Connection.getTournament_All();
            loadExistingTournamentDropDown.DataSource = null;
            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["senderDisplayName"].Length == 0 || ConfigurationManager.AppSettings["senderEmail"].Length == 0)
            {
                MessageBox.Show("Chưa có thông tin người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                errorLabel.Visible = false;
                if (loadExistingTournamentDropDown.Items.Count != 0)
                {
                    TournamentModel tm = (TournamentModel)(loadExistingTournamentDropDown.SelectedItem);
                    TournamentViewerForm frm = new TournamentViewerForm(tm, this);
                    frm.Show();
                }
                else
                {
                    errorLabel.Visible = true;
                } 
            }
        }

        private void TournamentDashBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void deleteTournamentButton_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["senderDisplayName"].Length == 0 || ConfigurationManager.AppSettings["senderEmail"].Length == 0)
            {
                MessageBox.Show("Chưa có thông tin người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                errorLabel.Visible = false;
                if (loadExistingTournamentDropDown.Items.Count != 0)
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc bạn muốn hủy giải đấu này?",
                                         "Xác nhận xóa!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        TournamentModel tm = (TournamentModel)(loadExistingTournamentDropDown.SelectedItem);
                        GlobalConfig.Connection.deleteTournament(tm);
                        ReWireUp();
                        TournamentLogic.SendTournamentCancelEmail(tm);
                    }
                }
                else
                {
                    errorLabel.Visible = true;
                } 
            }
        }

        private void loadTournamentButton_MouseEnter(object sender, EventArgs e)
        {
            loadTournamentButton.ForeColor = Color.DarkGreen;
        }

        private void loadTournamentButton_MouseLeave(object sender, EventArgs e)
        {
            loadTournamentButton.ForeColor = Color.FromArgb(147, 197, 114);
        }

        private void deleteTournamentButton_MouseEnter(object sender, EventArgs e)
        {
            deleteTournamentButton.ForeColor = Color.DarkGreen;
        }

        private void deleteTournamentButton_MouseLeave(object sender, EventArgs e)
        {
            deleteTournamentButton.ForeColor = Color.FromArgb(147, 197, 114);
        }

        private void createTournamentButton_MouseEnter(object sender, EventArgs e)
        {
            createTournamentButton.ForeColor = Color.DarkGreen;
        }

        private void createTournamentButton_MouseLeave(object sender, EventArgs e)
        {
            createTournamentButton.ForeColor = Color.FromArgb(147, 197, 114);
        }
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private bool validateUser()
        {
            UserNameLabel.ForeColor = Color.FromArgb(147, 197, 114);
            EmailLabel.ForeColor = Color.FromArgb(147, 197, 114);
            bool output = true;
            if(UsernameTextBox.Text.Length == 0)
            {
                output = false;
                UserNameLabel.ForeColor = Color.Red;
            }
            if (EmailTextBox.Text.Length == 0 || !IsValidEmail(EmailTextBox.Text))
            {
                output = false;
                EmailLabel.ForeColor = Color.Red;
            }
            return output;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (validateUser())
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["senderDisplayName"].Value = UsernameTextBox.Text;
                config.AppSettings.Settings["senderEmail"].Value = EmailTextBox.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                UsernameTextBox.Text = ConfigurationManager.AppSettings["senderDisplayName"];
                EmailTextBox.Text = ConfigurationManager.AppSettings["senderEmail"];
                MessageBox.Show("Thay đổi thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
    }
}
