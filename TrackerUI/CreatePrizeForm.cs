using newTrackerLibrary;
using newTrackerLibrary.DataAccess;
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
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameValue.Text, placeNumberValue.Text, prizeAmountValue.Text, prizePercentageValue.Text);
                GlobalConfig.Connection.createPrize(model);
                callingForm.PrizeComplete(model);
                this.Close();
            }
        }

        //Kiểm tra dữ liệu vào
        private bool ValidateForm()
        {
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            if (!placeNumberValidNumber)
            {
                output = false;
                placeNumberLabel.ForeColor = Color.Red;
            }
            if(placeNumber < 1)
            {
                output = false;
                placeNumberLabel.ForeColor = Color.Red;
            }
            if(placeNameValue.Text.Length == 0)
            {
                output = false;
                placeNameLabel.ForeColor = Color.Red;
            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if(!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
                prizeAmountLabel.ForeColor = Color.Red;
                prizePercentageLabel.ForeColor = Color.Red;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
                prizeAmountLabel.ForeColor = Color.Red;
                prizePercentageLabel.ForeColor = Color.Red;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
                prizePercentageLabel.ForeColor = Color.Red;
            }
            return output;
        }
    }
}
