namespace L2._6.Part3
{
    public class Program
    {
        public static void Cone(int n)
        {
            for(int p=0 ; p<n-n/2-1 ; p++)
                Console.Write(" ");

            Console.WriteLine("^");

            for(int i=0 ; i<n/2 ; i++)
            {
                for(int m=0 ; m<n/2-i-1 ; m++)
                    Console.Write(" ");

                for(int j=0 ; j<i+1 ; j++)
                    Console.Write("/");

                Console.Write("|");

                for(int k=0 ; k<i+1 ; k++)
                    Console.Write(@"\");

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Cone(7);
        }
    }
}


