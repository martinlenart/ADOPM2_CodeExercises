namespace DeepCopy
{
    internal class Program
    {
        class A 
        {
            public int val;
            public A(A other)
            {
                this.val = other.val;
            }
            public A()
            {

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] intArray2 = (int[]) intArray.Clone();
            intArray[0] = 10; intArray[1] = 11;

            foreach (var item in intArray)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine();

            foreach (var item in intArray2)
            {
                Console.Write($"{item,5}");
            }

            Console.WriteLine();
            Console.WriteLine();
            A[] aArray1 = { new A { val = 1 }, new A { val = 2 }, new A { val = 3 } };
            
            //Deep Copy
            A[] aArray2 = (A[]) aArray1.Clone();
            for (int i = 0; i < aArray1.Length; i++)
            {
                aArray2[i] = new A(aArray1[i]);
            }
            
            aArray1[0].val = 10; aArray1[1].val = 11;


            foreach (var item in aArray1)
            {
                Console.Write($"{item.val,5}");
            }
            Console.WriteLine();

            foreach (var item in aArray2)
            {
                Console.Write($"{item.val,5}");
            }


        }
    }
}