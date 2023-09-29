using newTrackerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class SelectDatabaseForm : Form
    {
        List<DatabaseType> Databases = new List<DatabaseType>();
        public SelectDatabaseForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            filePathText.Text = ConfigurationManager.AppSettings["filePath"];
            WireUp();
        }

        private void WireUp()
        {
            Databases.Add(DatabaseType.Sql);
            Databases.Add(DatabaseType.TextFile);
            databaseCombobox.DataSource = Databases;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["filePath"].Length != 0)
            {
                GlobalConfig.InitializeConnections((DatabaseType)databaseCombobox.SelectedItem);
                TournamentDashBoardForm frm = new TournamentDashBoardForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chưa chọn nơi lưu cơ sở dữ liệu", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectFilePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath = fbd.SelectedPath;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["filePath"].Value = folderPath;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                filePathText.Text = ConfigurationManager.AppSettings["filePath"];
            }
        }

        private void databaseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filePathText.Enabled = false;
            selectFilePathButton.Enabled = false;
            filePathLabel.ForeColor =  Color.Black;
            if ((DatabaseType)databaseCombobox.SelectedItem == DatabaseType.TextFile)
            {
                selectFilePathButton.Enabled = true;
                filePathText.Enabled = true;
                filePathLabel.ForeColor = Color.FromArgb(51, 153, 255);
            }
        }
    }
}
