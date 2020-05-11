using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutPiggybank
{
    class PiggyBank
    {
        private int nrOf2EuroCoins;
        private int nrOf1EuroCoins;
        private String ownerName; //the name of the owner of this piggybank

        public void AddA2EuroCoin()
        {
            this.nrOf2EuroCoins = this.nrOf2EuroCoins + 1;
        }

        public void AddA1EuroCoin()
        {
            this.nrOf1EuroCoins = this.nrOf1EuroCoins + 1;
        }

        public int GetNrOf2EuroCoins()
        {
            return this.nrOf2EuroCoins;
        }

        public void SetNrOf2EuroCoins(int amount)
        {
            this.nrOf2EuroCoins = amount;
        }

        public String GetOwnerName()
        {
            return this.ownerName;
        }

        public void SetOwnerName(String name)
        {
            this.ownerName = name;
        }

        public String GetInfo()
        {
            String holder;
            holder = "owner name is " + this.ownerName +
                " and nr of 2-euro-coins is " + this.nrOf2EuroCoins +
                " and nr of 1-euro-coins is " + this.nrOf1EuroCoins ;
            return holder;
        }

        public void AddSomeMoney(int nrOf2EuroCoins, int nrOf1EuroCoins)
        {
            this.nrOf2EuroCoins = this.nrOf2EuroCoins + nrOf2EuroCoins;
            this.nrOf1EuroCoins = this.nrOf1EuroCoins + nrOf1EuroCoins;
        }
    }
}
