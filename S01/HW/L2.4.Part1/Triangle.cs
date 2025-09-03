namespace L2._4.Part1
{
    public class Program
    {
        public static void Draw(int x)
        {
            for(int i=0 ; i<x ; i++)
            {
                for(int j=0 ; j<i+1 ; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Draw(x);
        }
    }
}