using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokerBetSizeCalculator
{
    public partial class BetSizeCalculator : Form
    {
        public BetSizeCalculator()
        {
            InitializeComponent();
        }

        private void btnTwoQuarter_Click(object sender, EventArgs e)
        {
            var NoOfBigBlinds = 2.25;
            var sum = BetSize(NoOfBigBlinds);
            lblBet.Text = sum.ToString();
        }

        private void btnTwoHalf_Click(object sender, EventArgs e)
        {
            var NoOfBigBlinds = 2.5;
            var sum = BetSize(NoOfBigBlinds);
            lblBet.Text = sum.ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            var NoOfBigBlinds = 3;
            var sum = BetSize(NoOfBigBlinds);
            lblBet.Text = sum.ToString();
        }

        private int BetSize(double NoOfBigBlinds)
        {
            var BigBlind = Convert.ToInt32(txtBigBlind.Text);
            int Limpers;

            if (txtLimpers.Text != "")
                Limpers = Convert.ToInt32(txtLimpers.Text);
            else
                Limpers = 0;

            var sum = BigBlind * (NoOfBigBlinds + Limpers);
            var random = GetRandomNumber(1,100);
            return Convert.ToInt32(sum) + random;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            var NoOfBigBlinds = 4;
            var sum = BetSize(NoOfBigBlinds);
            lblBet.Text = sum.ToString();
        }

        public int GetRandomNumber(int minimum, int maximum)
        {
            Random random = new Random();
            var result = random.NextDouble() * (maximum - minimum) + minimum;
            return Convert.ToInt32(result);
        }

        private void btntwotwo_Click(object sender, EventArgs e)
        {
            var NoOfBigBlinds = 2.2;
            var sum = BetSize(NoOfBigBlinds);
            lblBet.Text = sum.ToString();
        }

        private void btnTwoSeven_Click(object sender, EventArgs e)
        {
            var NoOfBigBlinds = 2.7;
            var sum = BetSize(NoOfBigBlinds);
            lblBet.Text = sum.ToString();
        }

        private void btnThreeFive_Click(object sender, EventArgs e)
        {
            var NoOfBigBlinds = 3.5;
            var sum = BetSize(NoOfBigBlinds);
            lblBet.Text = sum.ToString();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (txtPotSize.Text == String.Empty)
                txtPotSize.Text = "0";
            var PotSize = Convert.ToInt32(txtPotSize.Text);
            double Percentage;
            if (txtPercentage.Text != String.Empty)
            {
                Percentage = Convert.ToDouble(txtPercentage.Text);
                if (Percentage > 100)
                    Percentage = 100;
            }         
            else
                Percentage = 0;
            


            var Total = PotSize * (Percentage / 100);
            lblBet.Text = Total.ToString();
        }

        private void btnBigBlinds_Click(object sender, EventArgs e)
        {
            if (txtStack.Text == String.Empty)
                txtStack.Text = "0";

            if (txtCurrentBB.Text == String.Empty)
                txtCurrentBB.Text = "20";

            var stack = Convert.ToDouble(txtStack.Text);
            var bbsize = Convert.ToDouble(txtCurrentBB.Text);

            var total = stack / bbsize;

            lblBet.Text = total.ToString();

            PlayAdvice();
        }

        private void tabChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 2)
            {
                lblBetAmount.Text = "BB Remaining";
                lblPlayAdvice.Text = "Advice";
                txtAdvice.Visible = true;
                lblPlayAdvice.Visible = true;
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                lblBetAmount.Text = "Equity";
                lblPlayAdvice.Text = "Pot Odds";
                txtAdvice.Visible = true;
                lblPlayAdvice.Visible = true;
            }
            else
            {
                lblBetAmount.Text = "Amount to Bet";
                txtAdvice.Visible = false;
                lblPlayAdvice.Visible = false;
            }
        }

        private void PlayAdvice()
        {
            var noOfBigBlinds = Convert.ToDouble(lblBet.Text);

            if (noOfBigBlinds < 5.0)
            {
                txtAdvice.Text = "Shove pretty much any two cards, you are in trouble!";
                txtAdvice.ForeColor = Color.Red;
            }
            else if ((noOfBigBlinds > 10.0) && (noOfBigBlinds < 15.0))
            {
                txtAdvice.Text = "You should be looking for a spot to get your entire stack in";
                txtAdvice.ForeColor = Color.Red;
            }
            else if ((noOfBigBlinds > 15.0) && (noOfBigBlinds < 25.0))
            {
                txtAdvice.Text = "Play tight aggressive poker";
                txtAdvice.ForeColor = Color.Green;
            }
            else if ((noOfBigBlinds > 25.0) && (noOfBigBlinds < 35.0))
            {
                txtAdvice.Text = "Play tight aggressive poker, but expand on the range of hands you are playing.";
                txtAdvice.ForeColor = Color.Green;
            }
            else if (noOfBigBlinds > 35.0)
            {
                txtAdvice.Text = "Bully people as much as you can to ensure that your stack remains healthy.";
                txtAdvice.ForeColor = Color.Green;
            }
            
        }

        private void btnCalculateEquity_Click(object sender, EventArgs e)
        {
            var outs = Convert.ToInt32(txtOuts.Text);
            double equity = 0.0;
            switch(comStage.SelectedItem.ToString())
            {
                case "Flop":
                    if (outs > 8)
                        equity = (outs * 4) - (outs - 8);
                    else
                        equity = outs * 4;
                    break;

                case "Turn":
                        equity = outs * 2;
                    break;

                case "River":
                        equity = 0;
                    break;
            }
            
            lblBet.Text = equity.ToString() + "%";
            var remainder = 100 - equity;

            var left = remainder / equity;
            var right = remainder / remainder;

            var message = String.Empty;

            if (left < 2.1)
            {
                message = " not worth a call";
            }
            else if (left > 2.1)
            {
                message = " you should call";
            }

            txtAdvice.Text = left.ToString("0.00") + "-" + right.ToString() + message;
        }

    }
}
