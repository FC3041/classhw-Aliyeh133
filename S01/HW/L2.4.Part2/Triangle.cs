namespace L2._4.Part2
{
        public class Program
    {
        public static void Draw(int x,char c)
        {
            for(int i=0 ; i<x ; i++)
            {
                for(int j=0 ; j<i+1 ; j++)
                    Console.Write(c);

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Draw(x,ch);
        }
    }
}
