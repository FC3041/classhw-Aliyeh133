namespace L2._10.Part1
{
    public class Program
    {
        public static int Factorial(int n)
        {
            if(n==1 || n==0)
                return 1 ;

            int i = 1 ;
            int s = 1 ;
            while(i<n+1)
            {
                s *= i ;
                i++ ;
            }
            return s ;
        }

        public static void E(double precision)
        {
            int a = 0 ;
            double e = 0 ;
            while(true)
            {
                e += Math.Pow(1,a)/Factorial(a) ;
                a += 1 ;
                if (Math.Pow(1,a)/Factorial(a) < precision)
                    break ;
            }
            Console.Write(e);
        }

        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            E(x);
        }
    }
}


