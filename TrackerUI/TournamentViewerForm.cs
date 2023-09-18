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
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchup = new BindingList<MatchupModel>();


        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            tournament = tournamentModel;

            tournament.OnTournamentComplete += Tournament_OnTournamentComplete; ;

            LoadFormData();

            LoadRound();
        }

        private void Tournament_OnTournamentComplete(object sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void LoadRound()
        {
            rounds = new BindingList<int>();

            rounds.Add(1);
            int currRound = 1;

            foreach(List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            WireUpRounds();
        }

        private void WireUpRounds()
        {
            roundDropDown.DataSource = rounds;
        }

        private void WireUpMatchups()
        { 
            matchupListBox.DataSource = selectedMatchup;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            int round = (int)roundDropDown.SelectedItem;
            selectedMatchup = new BindingList<MatchupModel>();
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {  
                if (matchups.First().MatchupRound == round)
                {
                    foreach(MatchupModel matchup in matchups)
                    {
                        if (matchup.Winner == null || !unplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchup.Add(matchup);
                        }
                    }
                }
            }
            WireUpMatchups();
            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchup.Count > 0);
            teamOneNameLabel.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreValue.Visible = isVisible;
            teamTwoNameLabel.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreValue.Visible= isVisible;
            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;

        }

        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            
            for(int i = 0; i < m.Entries.Count; i++)
            {
                if(i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        teamTwoNameLabel.Text = "<bye>";
                        teamTwoScoreValue.Text = "0";
                    }
                    else
                    {
                        teamOneNameLabel.Text = "Chưa được đặt";
                        teamOneScoreValue.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoNameLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoNameLabel.Text = "Chưa được đặt";
                        teamTwoScoreValue.Text = "";
                    }
                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateForm();
            if(errorMessage.Length == 0)
            {
                MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
                int teamOneScore = 0;
                int teamTwoScore = 0;

                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            bool scoreValid = int.TryParse(teamOneScoreValue.Text, out teamOneScore);
                            if (scoreValid)
                            {
                                m.Entries[0].Score = teamOneScore;
                            }
                            else
                            {
                                MessageBox.Show("Place holder");
                                return;
                            }
                        }
                    }
                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            bool scoreValid = int.TryParse(teamTwoScoreValue.Text, out teamTwoScore);
                            if (scoreValid)
                            {
                                m.Entries[1].Score = teamTwoScore;
                            }
                            else
                            {
                                MessageBox.Show("Place holder");
                                return;
                            }
                        }
                    }
                }
                try
                {
                    TournamentLogic.UpdateTournamentResult(tournament);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ứng dụng bị lỗi sau: {ex.Message}");
                    return;
                }
                LoadMatchups();
            }
            
        }

        private string ValidateForm()
        {
            teamOneScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            errorMessage.Visible = false;
            string output = "";
            bool teamOneScoreValid = int.TryParse(teamOneScoreValue.Text, out int teamOneScoreOutput);
            bool teamTwoScoreValid = int.TryParse(teamTwoScoreValue.Text, out int teamTwoScoreOutput);
            if (!teamOneScoreValid && !teamTwoScoreValid)
            {
                output = "Giá trị của tỉ số cả hai đội không phải số.";
                errorMessage.Text = output;
                errorMessage.Visible = true;
                teamOneScoreLabel.ForeColor = Color.Red;
                teamTwoScoreLabel.ForeColor = Color.Red;
            }
            else
            {
                if (!teamOneScoreValid)
                {
                    output = "Giá trị của tỉ số đội một không phải số.";
                    errorMessage.Text = output;
                    errorMessage.Visible = true;
                    teamOneScoreLabel.ForeColor = Color.Red;
                }
                else if (!teamTwoScoreValid)
                {
                    output = "Giá trị của tỉ số đội hai không phải số.";
                    errorMessage.Text = output;
                    errorMessage.Visible = true;
                    teamTwoScoreLabel.ForeColor = Color.Red;
                }
                else if (teamOneScoreOutput == 0 && teamTwoScoreOutput == 0)
                {
                    output = "Chưa đặt tỉ số cho cả 2 đội.";
                    errorMessage.Text = output;
                    errorMessage.Visible = true;
                    teamOneScoreLabel.ForeColor = Color.Red;
                    teamTwoScoreLabel.ForeColor = Color.Red;
                }
                else if (teamOneScoreOutput == teamTwoScoreOutput)
                {
                    output = "Không cho phép hòa trong giải đấu này.";
                    errorMessage.Text = output;
                    errorMessage.Visible = true;
                    teamOneScoreLabel.ForeColor = Color.Red;
                    teamTwoScoreLabel.ForeColor = Color.Red;
                }
            }
            return output;
        }
    }
}
