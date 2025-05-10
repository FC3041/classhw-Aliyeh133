namespace L2._4.Part3
{
    public class Program
    {
        public static void Draw(int x)
        {
            for(int i=0 ; i<x ; i++)
            {
                for(int j=0 ; j<x-i-1 ; j++)
                    Console.Write(" ");

                for(int k=0 ; k<i+1 ; k++)
                    Console.Write("*");
                
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Draw(x);
        }
    }
}
