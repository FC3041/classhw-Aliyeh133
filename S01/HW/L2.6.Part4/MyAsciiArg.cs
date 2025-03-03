namespace L2._6.Part4
{
    public class Program
    {
        public static void Cone(int n)
        {
            for(int p=0 ; p<n-n/2-1 ; p++)
                Console.Write(" ");

            Console.WriteLine("^");

            if(n==1)
                Console.WriteLine("|");                

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
            // N%2 = 1
            for(int i=0 ; i<5 ; i++)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                Cone(N);
            }
        }
    }
}



