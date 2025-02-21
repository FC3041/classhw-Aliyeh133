namespace L2._10.Part3
{
    public class Program
    {
        public static double Mathematics(double x , double precision)
        {
            double e = 1 ;
            double E = x ;
            int n = 1 ;
            while(true)
            {
                e += E ;
                n += 1 ;
                E *= x/n ;
                if(E < precision)
                    break ;
            }
            return e ;
        }

        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write(Mathematics(x,y));
        }
    }
}

