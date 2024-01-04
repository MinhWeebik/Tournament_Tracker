using newTrackerLibrary;
using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class EditTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.getPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private List<PersonModel> searchResultTeamMembers = new List<PersonModel>();
        TeamModel team = new TeamModel();
        CreateTournamentForm formCalled;
        public EditTeamForm(TeamModel model, CreateTournamentForm caller)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            team = model;
            formCalled = caller;
            showData();
            WireUpList();
        }

        private void WireUpList()
        {
            SearchResult();
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = searchResultTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void SearchResult()
        {
            searchResultTeamMembers = new List<PersonModel>();
            if (searchValue.Text.Length != 0)
            {
                foreach (PersonModel person in availableTeamMembers)
                {
                    if (TournamentLogic.IsMatch(searchValue.Text.ToLower(), person.FullName.ToLower()))
                    {
                        searchResultTeamMembers.Add(person);
                    }
                }
            }
            else
            {
                searchResultTeamMembers = availableTeamMembers;
            }
        }

        private void showData()
        {
            teamNameValue.Text = team.TeamName;
            foreach(PersonModel member in team.TeamMembers)
            {
                selectedTeamMembers.Add(member);
            }
            int count = availableTeamMembers.Count;
            int currTeamMemberId = 0;
            int currPosition = 0;
            while(currPosition <= availableTeamMembers.Count - 1)
            {
                currTeamMemberId = availableTeamMembers[currPosition].Id;
                foreach (PersonModel p in selectedTeamMembers)
                {
                    if (availableTeamMembers[currPosition].Id == p.Id)
                    {
                        availableTeamMembers.RemoveAt(currPosition);
                        break;
                    }
                }
                if (currPosition > availableTeamMembers.Count - 1)
                {
                    break;
                }
                if (currTeamMemberId == availableTeamMembers[currPosition].Id)
                {
                    currPosition++;
                }
            }
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

        private bool ValidatePerson()
        {
            emailErrorLabel.Visible = false;
            firstNameLabel.ForeColor = Color.FromArgb(147, 197, 114);
            lastNameLabel.ForeColor = Color.FromArgb(147, 197, 114);
            emailLabel.ForeColor = Color.FromArgb(147, 197, 114);
            cellphoneLabel.ForeColor = Color.FromArgb(147, 197, 114);
            bool output = true;
            if (firstNameValue.Text.Length == 0)
            {
                output = false;
                firstNameLabel.ForeColor = Color.Red;
            }
            if (lastNameValue.Text.Length == 0)
            {
                output = false;
                lastNameLabel.ForeColor = Color.Red;
            }
            if (emailValue.Text.Length == 0)
            {
                output = false;
                emailLabel.ForeColor = Color.Red;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                output = false;
                cellphoneLabel.ForeColor = Color.Red;
            }
            if (!IsValidEmail(emailValue.Text))
            {
                output = false;
                emailErrorLabel.Visible = true;
                emailLabel.ForeColor = Color.Red;
            }
            return output;
        }

        private bool ValidateTeam()
        {
            teamNameLabel.ForeColor = Color.FromArgb(147, 197, 114);
            errorMessageLabel.Visible = false;
            bool output = true;
            if (teamNameValue.Text.Length == 0)
            {
                output = false;
                teamNameLabel.ForeColor = Color.Red;
            }
            if (teamMembersListBox.Items.Count == 0)
            {
                output = false;
                
            }
            return output;
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidatePerson())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;
                GlobalConfig.Connection.createPerson(p);
                selectedTeamMembers.Add(p);
                GlobalConfig.Connection.createTeamMember(p, team);
                WireUpList();
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            errorMessageLabel.Visible = false;
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                GlobalConfig.Connection.createTeamMember(p,team);
                WireUpList();
            }
        }

        private void deleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            errorMessageLabel.Visible = false;
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null && teamMembersListBox.Items.Count > 1)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);
                GlobalConfig.Connection.deleteTeamMember(p,team);
                WireUpList();
            }
            else
            {
                errorMessageLabel.Visible = true;
            }
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            if(ValidateTeam())
            {
                GlobalConfig.Connection.updateTeam(team, teamNameValue.Text);
                formCalled.ReWireUp();
                this.Close();
            }
        }

        private void deleteTeamButton_Click_1(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Bạn có chắc bạn muốn xóa đội này?",
                                     "Xác nhận xóa!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                GlobalConfig.Connection.deleteTeam(team);
                formCalled.ReWireUp();
                this.Close();
            }
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void addMemberButton_MouseEnter(object sender, EventArgs e)
        {
            addMemberButton.ForeColor = Color.DarkGreen;
        }

        private void addMemberButton_MouseLeave(object sender, EventArgs e)
        {
            addMemberButton.ForeColor = Color.FromArgb(147, 197, 114);
        }

        private void createMemberButton_MouseEnter(object sender, EventArgs e)
        {
            createMemberButton.ForeColor = Color.DarkGreen;

        }

        private void createMemberButton_MouseLeave(object sender, EventArgs e)
        {
            createMemberButton.ForeColor = Color.FromArgb(147, 197, 114);

        }

        private void updateTeamButton_MouseEnter(object sender, EventArgs e)
        {
            updateTeamButton.ForeColor = Color.DarkGreen;

        }

        private void updateTeamButton_MouseLeave(object sender, EventArgs e)
        {
            updateTeamButton.ForeColor = Color.FromArgb(147, 197, 114);

        }

        private void deleteTeamButton_MouseEnter(object sender, EventArgs e)
        {
            deleteTeamButton.ForeColor = Color.DarkGreen;

        }

        private void deleteTeamButton_MouseLeave(object sender, EventArgs e)
        {
            deleteTeamButton.ForeColor = Color.FromArgb(147, 197, 114);

        }

        private void deleteSelectedMemberButton_MouseEnter(object sender, EventArgs e)
        {
            deleteSelectedMemberButton.ForeColor = Color.DarkGreen;

        }

        private void deleteSelectedMemberButton_MouseLeave(object sender, EventArgs e)
        {
            deleteSelectedMemberButton.ForeColor = Color.FromArgb(147, 197, 114);

        }
    }
}
