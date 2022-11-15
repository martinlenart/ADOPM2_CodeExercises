using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FriendList
{
    public struct AddressType
    {
        public string Street { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            string sRet = $"{City} in {Country}";
            return sRet;
        }

        public static class Factory
        {
            public static AddressType CreateRandom()
            {
                string[] streets = "Mainstreet, Backstreet, Sidestreet, Up Blvd, Down Blvd".Split(", ");
                string[] cities = "Stockholm, Gavle, Malmo, Gothenburg".Split(", ");
                string[] countries = "Sweden, Norway, Denmark, Finland".Split (", ");

                var rnd = new Random();
                string street = streets[rnd.Next(streets.Length)];
                int zip = rnd.Next(11111, 99999);
                string city = cities[rnd.Next(cities.Length)];
                string country = countries[rnd.Next(countries.Length)];

                AddressType adr = new AddressType { Street=street, Zip=zip, City=city, Country=country };
                return adr;
            }
        }
    }
}
