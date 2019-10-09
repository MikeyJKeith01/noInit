using System;
using System.Collections.Generic;
using System.Text;

namespace MoonPigLibrary
{
    class birthday : card
    {
        public string[] line1, line2, line3, line4, line5;

        public birthday()
        {
            line1 = new string[3] { "Count your life by smiles, not tears.", "You are only young once,", "It’s birthday time again, and wow!" };
            line2 = new string[3] { "Count your age by friends, not years.", "but you can be immature for a lifetime.", "You’re a whole year older now!" };
            line3 = new string[3] { "Happy birthday!", "Happy birthday!", "So clown around and have some fun," };
            line4 = new string[3] { "", "", "to make this birthday your best one." };
            line5 = new string[3] { "", "", "Happy birthday!" };
        }
        public void RandomizeMessage(string cardType)
        {
            Random random = new Random();

            int rnd = random.Next(0, 4);

        }
    }
}
