using System.Runtime.CompilerServices;

namespace L2._10.Part3B
{
    public class Program
    {
        public static double Factorial(double n)
        {
            if(n==0)
                return 1 ;
            double multi = 1 ;
            for(int i=1 ; i<n+1 ; i++)
                multi *= i ;
            return multi ;
        }
            

        public static double Power(double x,double y)
        {
            double X = 1 ;
            if(y==0)
                return 1 ;
            else
            {
                for(int i=0 ; i<y ; i++)
                    X *= x ;
            }
            return X ;
        }

        public static double E(double a,double precision)
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

        public static double E2(double x , double precision)
        {
            double e2 = 1 ;
            double E = x ;
            int n = 1 ;
            while(true)
            {
                e2 += E ;
                n += 1 ;
                E *= x/n ;
                if(E < precision)
                    break ;
            }
            return e2 ;
        }

        public static double Abso(double x)
        {
            if(x>=0)
                return x ;
            return -x ;
        }

        public static bool Close(double x,double precision,double closeness)
        {
            double e = E(x,precision) ;
            double e2 = E2(x,precision) ;
            while((Abso(e-e2) <= closeness*Abso(e2)) && (Abso(e-e2) <= closeness*Abso(e2)))
                    return true ; 
            return false ;
        }

        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write(Close(x,y,c));
        }
    }
}