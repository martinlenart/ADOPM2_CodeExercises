namespace getSet
{
    internal class Test
    {
        public int i; //Field
        public int i_get { get; } = 50;

        public int i_set { private get;  set; }

        public int Mult { get { return i_set * 20; } }
        public Test()
        {
            i_get = 500;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var myTest = new Test();
            myTest.i = 1;
            Console.WriteLine(myTest.i);

            Console.WriteLine(myTest.i_get);

            myTest.i_set= 100;
            Console.WriteLine(myTest.Mult);


        }
    }
}