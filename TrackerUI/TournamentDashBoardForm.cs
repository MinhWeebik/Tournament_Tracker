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
    public partial class TournamentDashBoardForm : Form
    {
        
        List<TournamentModel> tournaments = GlobalConfig.Connection.getTournament_All();
        public TournamentDashBoardForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            WireUp();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm(this);
            frm.Show();
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

        private void TournamentDashBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void deleteTournamentButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            if (loadExistingTournamentDropDown.Items.Count != 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc bạn muốn xóa giải đấu này?",
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
}
