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
            if (ConfigurationManager.AppSettings["filePath"].Length != 0 || (DatabaseType)databaseCombobox.SelectedItem == DatabaseType.Sql)
            {
                GlobalConfig.InitializeConnections((DatabaseType)databaseCombobox.SelectedItem);
                TournamentDashBoardForm frm = new TournamentDashBoardForm();
                frm.Show();
                this.Hide();
            }
            else if((DatabaseType)databaseCombobox.SelectedItem == DatabaseType.TextFile)
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
                filePathLabel.ForeColor = Color.FromArgb(147, 197, 114);
            }
        }

        private void selectButton_MouseEnter(object sender, EventArgs e)
        {
            selectButton.ForeColor = Color.DarkGreen;

        }

        private void selectButton_MouseLeave(object sender, EventArgs e)
        {
            selectButton.ForeColor = Color.FromArgb(147, 197, 114);

        }

        private void selectFilePathButton_MouseEnter(object sender, EventArgs e)
        {
            selectFilePathButton.ForeColor = Color.DarkGreen;

        }

        private void selectFilePathButton_MouseLeave(object sender, EventArgs e)
        {
            selectFilePathButton.ForeColor = Color.FromArgb(147, 197, 114);

        }
    }
}
