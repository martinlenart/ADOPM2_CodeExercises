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
            for (int i = 0; i < 10_000; i++)
            {
                myFriends.Add(Friend.Factory.CreateRandom());
            }

            Console.WriteLine("\nFirst 20");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(myFriends[i]);
            }
            Console.WriteLine("\nLast 20");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(myFriends[myFriends.Count-1-i]);
            }

            Console.WriteLine("\nFriendList - friends1");
            var friends1 = FriendList.Factory.CreateRandom(10);
            Console.WriteLine(friends1);

            Console.WriteLine("\nFriendList - friends2");
            var friends2 = FriendList.Factory.CreateRandom(5);
            Console.WriteLine(friends2);

            friends1.myFriends = null;

        }
    }
}