namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My 10 integers!");
            int[] myInts = { 1, 2, 5, 10, 3, 2, 9, 56, 12, 15 };

            Console.WriteLine();
            PrintArray(myInts);

            Console.WriteLine();
            Console.WriteLine(myInts[7]);

            Console.WriteLine();
            Console.WriteLine(FindNumber(57, myInts));

            Console.WriteLine();
            Console.WriteLine(MaxNumber(myInts));

            Console.WriteLine();
            Console.WriteLine(MinNumber(myInts));


            void PrintArray(int[] _ints)
            {
                foreach (var item in _ints)
                {
                    Console.WriteLine(item);
                }
            }

            bool FindNumber(int number, int[] _ints)
            {
                foreach (var item in _ints)
                {
                    if (item == number)
                    {
                        return true;
                    }
                }
                return false;
            }

            int MaxNumber(int[] _ints)
            {
                int _max = int.MinValue;
                foreach (var item in _ints)
                {
                    if (item > _max)
                    {
                        _max = item;
                    }
                }
                return _max;
            }
            int MinNumber(int[] _ints)
            {
                int _min = int.MaxValue;
                foreach (var item in _ints)
                {
                    if (item < _min)
                    {
                        _min = item;
                    }
                }
                return _min;
            }
        }
    }
}