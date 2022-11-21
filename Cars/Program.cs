namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car { Make = CarMake.BMW, Model = "3 series", Year = 2021 };
            Car c2 = new Car { Make = CarMake.Volvo, Model = "V70", Year = 2020 };
            Car c3 = new Car { Make = CarMake.Honda, Model = "Civic", Year = 2019 };
            Car c4 = new Car { Make = CarMake.Volvo, Model = "V70", Year = 2020 };
            Car c5 = new Car { Make = CarMake.BMW, Model = "5 series", Year = 2017 };


            Console.WriteLine(c2);
            Console.WriteLine(c4);


            Console.WriteLine(c2 == c4);


            List<Car> myCars = new List<Car>();
            Car aCar = new Car { Make = CarMake.BMW, Model = "V70", Year = 2020 };
            myCars.Add(c1);
            myCars.Add(c2);
            myCars.Add(c3);
            myCars.Add(c4);
            myCars.Add(c5);


            var found = myCars.Contains(aCar);
            Console.WriteLine(found);

            foreach (var car in myCars)
            {
                if (car == aCar)
                    Console.WriteLine("Car found");
            }

            myCars.Sort();
            foreach (var car in myCars)
            {
                Console.WriteLine(car);
            }


        }
    }
}