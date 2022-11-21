// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace FriendList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Friend f1 = new Friend {
                FirstName = "Mikael", LastName = "Petersen",
                Email = "m.petersen@gmail.com", Address= new AddressType {
                    Street = "Mainstreet 1", Zip=12345, City="Gavle", Country="Sweden"}
            };

            Console.WriteLine(f1.ToString());

            Friend f2 = new Friend("Anne", "Sterling", "a.sterling@icloud.com",
                new AddressType { Street = "Backstreet 3", Zip = 98765, City = "Sigtuna", Country = "Sweden" });

            Console.WriteLine(f2);

            Friend f3 = Friend.Factory.CreateRandom();
            Console.WriteLine(f3);

            List<Friend> myFriends = new List<Friend>();
            for (int i = 0; i < 10; i++)
            {
                myFriends.Add(Friend.Factory.CreateRandom());
            }

            Console.WriteLine(myFriends[0]);
            Console.WriteLine(myFriends[myFriends.Count-1]);
        }
    }
}