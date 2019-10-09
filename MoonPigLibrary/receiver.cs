using System;
using System.Collections.Generic;
using System.Text;

namespace MoonPigLibrary
{
    class receiver
    {
        public string Name;
        public string AddressLine1;
        public string AddressLine2;
        public string AddressLine3;
        public string City;
        public string Postcode;

        public receiver()
        {
            Name = "untitled";
        }

        public void setReceiver(string name, string addressLine1, string addressLine2, string addressLine3, string city, string postcode)
        {
            this.Name = name;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.City = city;
            this.Postcode = postcode;
            
        }
    }
}
