using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutPiggybank
{
    public partial class Form1 : Form
    {
        private PiggyBank myPiggybank;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.myPiggybank = new PiggyBank();
            this.myPiggybank.SetOwnerName(this.textBox1.Text);
            this.btnAdd2EuroCoins.Enabled = true;
        }

        private void btnAdd2EuroCoins_Click(object sender, EventArgs e)
        {
            this.myPiggybank.AddA2EuroCoin();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (this.myPiggybank != null)
            {
                this.label1.Text = this.myPiggybank.GetInfo();
            }
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            int euro2, euro1;
            euro2 = Convert.ToInt32(this.tb2EuroCoins.Text);
            euro1 = Convert.ToInt32(this.tb1EuroCoins.Text);
            if (euro1 >= 0 && euro2 >= 0)
            {
                this.myPiggybank.AddSomeMoney(euro2, euro1);
            }

        }
    }
}
