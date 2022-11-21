using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList
{
    public struct Friend
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public AddressType Address { get; set; }
     
        public override string ToString()
        {
            string sRet = $"{FirstName} {LastName}, {Email}, from {Address.ToString()}";
            return sRet;
        }
        

        public Friend(string firstname, string lastname, string email, AddressType address)
        {
            this.FirstName= firstname;
            this.LastName= lastname ;
            this.Email= email ;
            this.Address= address ;
        }

        public static class Factory
        {
            public static Friend CreateRandom()
            {
                string[] firstnames = "Thomas, Ann, Mary, John".Split(", ");
                string[] lastnames = "Andersson, Jerez, Smith, Johansson".Split(", ");
                string[] domains = "icloud.com, hotmail.com, gmail.com".Split(", ");

                var rnd = new Random();
                string firstname = firstnames[rnd.Next(firstnames.Length)];
                string lastname = lastnames[rnd.Next(lastnames.Length)];
                string email = $"{firstname}.{lastname}@{domains[rnd.Next(domains.Length)]}";

                Friend friend = new Friend(firstname,lastname,email,AddressType.Factory.CreateRandom());
                return friend;
            }
        }

    }
}
