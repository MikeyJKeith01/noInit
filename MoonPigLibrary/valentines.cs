using System;
using System.Collections.Generic;
using System.Text;

namespace MoonPigLibrary
{
    class valentines : card
    {
        public string[] line1, line2, line3, line4, line5;

        public valentines()
        {
            line1 = new string[3] { "", "", "" };
            line2 = new string[3] { "", "", "" };
            line3 = new string[3] { "", "", "" };
            line4 = new string[3] { "", "", "" };
            line5 = new string[3] { "", "", "" };
        }

        public void RandomizeMessage(string cardType)
        {
            Random random = new Random();

            int rnd = random.Next(0, 4);

        }
    }
}
