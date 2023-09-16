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
            
            tournament = tournamentModel;

            LoadFormData();

            LoadRound();
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
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamOneScoreValue.Text, out teamOneScore);
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
                        bool scoreValid = double.TryParse(teamTwoScoreValue.Text, out teamTwoScore);
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

            if(teamOneScore > teamTwoScore)
            {
                m.Winner = m.Entries[0].TeamCompeting;
            }
            else if (teamTwoScore > teamOneScore) 
            {
                m.Winner = m.Entries[1].TeamCompeting;
            }
            else
            {
                MessageBox.Show("Khong xu ly tran hoa");
            }
            foreach(List<MatchupModel> round in tournament.Rounds)
            {
                foreach(MatchupModel rm  in round)
                {
                    foreach(MatchupEntryModel me in rm.Entries)
                    {
                        if (me.ParentMatchup != null)
                        {
                            if (me.ParentMatchup.Id == m.Id)
                            {
                                me.TeamCompeting = m.Winner;
                                GlobalConfig.Connection.updateMatchup(rm);
                            } 
                        }
                    }
                }
            }
            LoadMatchups();
            GlobalConfig.Connection.updateMatchup(m);
        }
    }
}
