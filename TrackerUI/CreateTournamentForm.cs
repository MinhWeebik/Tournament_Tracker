using newTrackerLibrary;
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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.getTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            WireUpList();
        }

        private void WireUpList()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";
            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";
            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if(t!=null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpList();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            prizeErrorLabel.Visible= false;
            if (prizesListBox.Items.Count < 2)
            {
                CreatePrizeForm frm = new CreatePrizeForm(this);
                frm.Show(); 
            }
            else
            {
                prizeErrorLabel.Visible = true;
            }
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpList();
        }

        public void teamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void deleteSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (p != null)
            {
                availableTeams.Add(p);
                selectedTeams.Remove(p);
                WireUpList();
            }
        }

        private void deleteSelectedTeamButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpList();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //Tạo tournament model
                TournamentModel tm = new TournamentModel();
                tm.TournamentName = tournamentNameValue.Text;
                tm.EntryFee = decimal.Parse(entryFeeValue.Text);
                tm.Prizes = selectedPrizes;
                tm.EnteredTeams = selectedTeams;

                //Tạo trận đấu
                TournamentLogic.CreateRounds(tm);

                //Tạo tournament entries
                //Tạo prize entries
                //Tạo team entries
                GlobalConfig.Connection.createTournament(tm);

                tm.AlertUserToNewRound();

                TournamentViewerForm frm = new TournamentViewerForm(tm);
                frm.Show();
                this.Close(); 
            }
        }

        private bool ValidateForm()
        {
            noTeamsErrorLabel.Visible  = false;
            prizeErrorLabel.Visible = false;
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            bool output = true;
            if(tournamentNameValue.Text.Length == 0)
            {
                output = false;
                tournamentNameLabel.ForeColor = Color.Red;
            }
            bool entryFeeValidate = decimal.TryParse(entryFeeValue.Text, out decimal fee);
            if(!entryFeeValidate || int.Parse(entryFeeValue.Text) == 0)
            {
                output = false;
                entryFeeLabel.ForeColor = Color.Red;
            }
            if(tournamentTeamsListBox.Items.Count == 0) 
            {
                output = false;
                noTeamsErrorLabel.Visible = true;
            }
            return output;
        }
    }
}
