namespace L2._10.Part4
{
    public class Program
    {

        public static int Factorial(int n)
        {
            if(n==0)
                return 1 ;
            int multi = 1 ;
            for(int i=1 ; i<n+1 ; i++)
                multi *= i ;
            return multi ;
        }
            

        public static double Sin(double X,double precision)
        {
            double x = X*Math.PI/180 ;
            int n = 1 ;
            double e = 1 ;
            double p = 0 ;
            while(true)
            {
                n += 2 ;
                p += 1 ;  
                e = e + (Math.Pow(-1,p)*(Math.Pow(x,n)/Factorial(n))) ;
                if(e > precision)
                    break ;
            }
            return e ;
        }

        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write(Sin(x,y));
        }
    }
}
