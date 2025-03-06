namespace L2._10.Part2
{
    public class Program
    {
        public static int Factorial(int n)
        {
            if(n==1 | n==0)
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

        public static double E(int a,double precision)
        {
            int n = 0 ;
            double e = 0 ;
            while(true)
            {
                e += Math.Pow(a,n)/Factorial(n) ;
                n += 1 ;
                if (Math.Pow(a,n)/Factorial(n) < precision)
                    break ;
            }
            return e ;
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write(E(x,y));
        }
    }

}

