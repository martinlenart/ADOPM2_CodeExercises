namespace Inheritance
{
    internal class Program
    {
        public class Chef
        {
            public string Name { get; set; } = "Boring";

            //try remove virtual
            virtual public string FavoriteDish => "really nothing";
            public override string ToString() => $"{Name} My favorite dish is {FavoriteDish}.";
        }

        //Declare a French Chef, Pierre who loves Escargot
        public class FrenchChef:Chef
        {
            public string Name { get; set; } = "Boring";

            //test remove override
            override public string FavoriteDish => "Snails";

            public FrenchChef()
            {
                Name = "Pierre";
            }
        }
        //Declare a German Chef, Klaus who loves Bratwurst

        //Declare a SouthGerman Chef, Heinz who loves Sauerkraut

        //Declare a Swedish Chef, Mats who loves Meatballs

        static void Main(string[] args)
        {
            //Inheritance
            Chef chef = new Chef();
            Console.WriteLine(chef);

            Console.WriteLine("\nFrenchChef");
            //Create the French, German, Swedish Chef
            FrenchChef fc = new FrenchChef();
            Console.WriteLine(fc.FavoriteDish);
            Console.WriteLine(fc);


            //Polymorfism
            List<Chef> list = new List<Chef>();

            //Add to the list the chef, French, German and Swedish chefs


            //Printout all chefs in list so it shows the child

        }
    }
}