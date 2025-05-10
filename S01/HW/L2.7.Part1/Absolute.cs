namespace L2._7.Part1
{
    public class Program
    {
        public static int Absolute(int a)
        {
            if(a>=0)
                return a ;
            return -a ;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Absolute(-100));
            Console.WriteLine(Absolute(-1));
            Console.WriteLine(Absolute(0));
            Console.WriteLine(Absolute(1));
            Console.WriteLine(Absolute(1000));
        }

    }
}
