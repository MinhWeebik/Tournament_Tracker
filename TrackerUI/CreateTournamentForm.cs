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
        private List<TeamModel> searchResultTeams = new List<TeamModel>();
        TournamentDashBoardForm formCaller;
        public CreateTournamentForm(TournamentDashBoardForm caller)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            formCaller = caller;
            WireUpList();
        }

        private void WireUpList()
        {
            SearchResult();
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = searchResultTeams;
            selectTeamDropDown.DisplayMember = "TeamName";
            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";
            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        public void ReWireUp()
        {
            availableTeams = GlobalConfig.Connection.getTeam_All();
            SearchResult();
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = searchResultTeams;
            selectTeamDropDown.DisplayMember = "TeamName";
        }

        private void SearchResult()
        {
            searchResultTeams = new List<TeamModel>();
            if (searchValue.Text.Length != 0)
            {
                foreach (TeamModel team in availableTeams)
                {
                    if (TournamentLogic.IsMatch(searchValue.Text.ToLower(), team.TeamName.ToLower()))
                    {
                        searchResultTeams.Add(team);
                    }
                }
            }
            else
            {
                searchResultTeams = availableTeams;
            }
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

        private TeamModel refreshTeamModel(TeamModel model)
        {
            List<TeamModel> allModel = GlobalConfig.Connection.getTeam_All();
            TeamModel newModel = new TeamModel();
            foreach(TeamModel t in allModel)
            {
                if(model.Id == t.Id)
                {
                    newModel = t;
                }
            }
            return newModel;
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

                TournamentViewerForm frm = new TournamentViewerForm(tm,formCaller);
                frm.Show();
                formCaller.ReWireUp();
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
                noTeamsErrorLabel.Text = "Chưa chọn đội nào";
                noTeamsErrorLabel.Visible = true;
            }
            if(tournamentTeamsListBox.Items.Count == 1)
            {
                output = false;
                noTeamsErrorLabel.Text = "Cần tối thiểu 2 đội";
                noTeamsErrorLabel.Visible = true;
            }
            return output;
        }

        private bool checkIfParticipating(TeamModel team)
        {
            bool output = false;
            List<TournamentModel> tournaments = GlobalConfig.Connection.getTournament_All();
            foreach(TournamentModel tournament in tournaments)
            {
                foreach(TeamModel t in tournament.EnteredTeams)
                {
                    if(team.Id == t.Id)
                    {
                        output = true;
                    }
                }
            }
            return output;
        }

        private void editTeamButton_Click(object sender, EventArgs e)
        {
            currentlyParticipatingErrorLabel.Visible = false;
            if (selectTeamDropDown.Items.Count != 0)
            {
                TeamModel newTeam = refreshTeamModel((TeamModel)selectTeamDropDown.SelectedItem);
                if (!checkIfParticipating(newTeam))
                {
                    EditTeamForm frm = new EditTeamForm(newTeam, this);
                    frm.Show();
                }
                else
                {
                    currentlyParticipatingErrorLabel.Text = "Đội này đang tham gia vào giải đấu";
                    currentlyParticipatingErrorLabel.Visible = true;
                } 
            }
            else
            {
                currentlyParticipatingErrorLabel.Text = "Chưa chọn đội nào để sửa";
                currentlyParticipatingErrorLabel.Visible = true;
            }
        }

        private void searchValue_TextChanged(object sender, EventArgs e)
        {
            ReWireUp();
        }
    }
}
