using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutDogRaces
{
    class Person
    {
        private String name;
        private int balance;
        private Bet myBet;

        public Person(String name, int balance)
        {
            this.name = name;
            this.balance = balance;
            this.myBet = null;
        }

        public Person(String name)
        { //a new member gets 10 euro as a gift
            this.name = name;
            this.balance = 10;
            this.myBet = null;
        }

        public String GetInfo()
        {
            String holder = this.name + ", balance: " + this.balance;
            if (this.myBet == null)
            {
                holder = holder + ", no bet yet.";
            }
            else
            {
                holder = holder + ", " + this.myBet.GetInfo();
            }
            return holder;
        }

        public bool PlaceBet(int amount, Dog d)
        {   //person may place 1 bet and change it as many times as he/she likes,
            //until the race starts.
            //It is not allowed to do a higher bet than the person's balance.
            //When the race starts, his/her balance will be lowered by the money of the bet.
            if (this.balance >= amount)
            {
                this.myBet = new Bet(amount, d);
                return true;
            }
            else
            {
                return false;
            }

        }

        public void PayForPlacingBetAtStartOfRace()
        {
            if(this.myBet != null)
            {//yes, you placed a bet, so you need to pay for it
                this.balance -=  this.myBet.GetAmount();
            }
        }

        public void PayOut(Dog winner)
        {  //when the race is finished, check if the person won.
            //if yes, he/she will receive 3 times the betting-money.
            if ( this.myBet != null &&  this.myBet.GetDog() == winner)
            {
                this.balance += 3 * this.myBet.GetAmount();
            }
        }
    }
}
