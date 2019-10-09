using System;
using System.Collections.Generic;
using System.Text;

namespace MoonPigLibrary
{
    class card 
    {
        public int CustID;
        public string CardType;

        public card()
        {
            CustID = 0;
        }

        public void CreateNewCard(int custID, string cardType)
        {
            this.CustID = custID;
            this.CardType = cardType;
        }

        public void RandomizeMessage(string cardType)
        {
            Random random = new Random();

            int rnd = random.Next(0,4);

            if (cardType == "valentines")
            {
                
            }
            else if (cardType == "getwellsoon")
            {

            }
            else if (cardType == "birthday")
            {

            }
            else if (cardType == "easter")
            {

            }
            else
            {
                
            }

        }
    }
}
