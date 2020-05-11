using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutDogRaces
{
    class Bet
    {
        //fields
        private int amount; //the amount of money of this bet
        private Dog bettedDog; // the dog on which you bet
        //constructors
        public Bet(int amount, Dog d)
        {
            this.amount = amount;
            this.bettedDog = d;
        }
        //methods

        public String GetInfo()
        {
            return "bet-amount: " + this.amount + " on dog " + this.bettedDog.GetName();
        }

        public int GetAmount() { return this.amount; }

        public Dog GetDog() { return this.bettedDog; }
    }
}
