using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutDogRaces
{
    public partial class Form1 : Form
    {
        private Person p1, p2, p3; // the 3 persons who will bet
        private Dog d1, d2, d3;    // the 3 dogs, participants in a dog race

        private Dog selectedDog; //alias for the selected dog
        private Person selectedPerson; //alias for the selected person

        private Dog winnerDog;
        private void rbDog1_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedDog = this.d1;
        }

        private void rbDog2_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedDog = this.d2;
        }

        private void rbDog3_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedDog = this.d3;
        }

        private void rbPerson1_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedPerson = this.p1;
        }

        private void rbPerson2_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedPerson = this.p2;
        }

        private void rbPerson3_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedPerson = this.p3;
        }

        public Form1()
        {
            InitializeComponent();
            this.p1 = new Person("Nawaf", 45);
            this.p2 = new Person("Aleksandar", 200);
            this.p3 = new Person("Pinar"); 
            this.d1 = new Dog("Blacky", "still young, but a future champ");
            this.d2 = new Dog("Wolfie", "is really fast");
            this.d3 = new Dog("Rambo", "needs a hugh before racing");

            this.ShowAllPersons();
            this.rbDog1.Text = this.d1.GetInfo();
            this.rbDog2.Text = this.d2.GetInfo();
            this.rbDog3.Text = this.d3.GetInfo();

            this.selectedPerson = this.p1;
            this.selectedDog = this.d2;
            this.winnerDog = null;
        }


        private void ShowAllPersons()
        {
            this.rbPerson1.Text = this.p1.GetInfo();
            this.rbPerson2.Text = this.p2.GetInfo();
            this.rbPerson3.Text = this.p3.GetInfo();

        }

        private void btnPlaceABet_Click(object sender, EventArgs e)
        {
            bool answer;
            answer = this.selectedPerson.PlaceBet(
                Convert.ToInt32(this.tbMoneyForBet.Text),
                this.selectedDog);
            if (answer == true)
            {
                this.ShowAllPersons();
            }
            else
            {
                MessageBox.Show("Sorry, you do not have enough money for that bet");
            }
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            this.btnPlaceABet.Enabled = false;
            this.p1.PayForPlacingBetAtStartOfRace();
            this.p2.PayForPlacingBetAtStartOfRace();
            this.p3.PayForPlacingBetAtStartOfRace();
        }

        private void btnPayOut_Click(object sender, EventArgs e)
        {
            this.winnerDog = this.d2;//suppose d2 is the winner
            this.p1.PayOut(this.winnerDog);
            this.p2.PayOut(this.winnerDog);
            this.p3.PayOut(this.winnerDog);
            this.ShowAllPersons();
        }
    }
}
