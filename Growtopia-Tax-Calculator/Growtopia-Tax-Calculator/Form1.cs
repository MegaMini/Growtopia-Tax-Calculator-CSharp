using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growtopia_Tax_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalBetAmount = int.Parse(totalBet.Text);
            double taxPercentage = double.Parse(taxAmount.Text, System.Globalization.CultureInfo.InvariantCulture);
            var result = Math.Round(totalBetAmount - ((taxPercentage / 100) * totalBetAmount));
            var youGet = totalBetAmount - result;

            result1.Text = $"You give winner {result} wls";
            result2.Text = $"You get {youGet} wls";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
