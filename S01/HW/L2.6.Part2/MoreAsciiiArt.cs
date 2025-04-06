namespace L2._6.Part2
{
    public class Program
    {
        public static void Triangle(int a)
        {
            for(int i=0 ; i<a ; i++)
            {
                if(i%2 == 0)
                {
                    for(int j=0 ; j<i+1 ; j++)
                        Console.Write("%");

                    Console.WriteLine();
                }
                

                if(i%2 == 1)
                {
                    for(int k=0 ; k<i+1 ; k++)
                        Console.Write("*");

                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Triangle(A);
        }
    }
}


