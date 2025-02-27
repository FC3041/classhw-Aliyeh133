namespace L2._7.Part5
{
    public class Program
    {
        public static int Fibonacci(int n)
        {   
            if(n==1 | n==2)
                return 1 ;

            int x1 = 1 ;
            int x2 = 1 ;
            int xn = 0 ;
            for(int i=2 ; i<n ; i++)
            {
                xn = x1 + x2 ;
                x1 = x2 ;
                x2 = xn ;
            }
            return xn ;
        }

        static void Main(string[] args)
        {
            for(int i=1 ; i<21 ; i++)
                Console.WriteLine(i + " " + Fibonacci(i));
        }
    }
}


