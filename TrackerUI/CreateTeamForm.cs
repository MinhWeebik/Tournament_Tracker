﻿using newTrackerLibrary;
using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.getPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            callingForm = caller;
            WireUpList();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Sơn", LastName = "Nguyễn Công"});
            availableTeamMembers.Add(new PersonModel { FirstName = "Dương", LastName = "Nguyễn Duy" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "A", LastName = "Nguyễn Công" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "B", LastName = "Nguyễn Công" });
        }

        private void WireUpList()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if(ValidatePerson())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;
                p = GlobalConfig.Connection.createPerson(p);
                selectedTeamMembers.Add(p);
                WireUpList();
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
        }

        private bool ValidatePerson()
        {
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellphoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            bool output = true;
            if(firstNameValue.Text.Length == 0 )
            {
                output = false;
                firstNameLabel.ForeColor = Color.Red;
            }
            if(lastNameValue.Text.Length == 0 )
            { 
                output = false;
                lastNameLabel.ForeColor = Color.Red;
            }
            if(emailValue.Text.Length == 0 )
            {
                output = false;
                emailLabel.ForeColor = Color.Red;
            }
            if(cellphoneValue.Text.Length == 0 )
            {
                output = false;
                cellphoneLabel.ForeColor = Color.Red;
            }
            return output;
        }


        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpList(); 
            }
        }

        private void deleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if(p != null )
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);
                WireUpList();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;
            GlobalConfig.Connection.createTeam(t);
            callingForm.teamComplete(t);
            this.Close();
        }
    }
}
