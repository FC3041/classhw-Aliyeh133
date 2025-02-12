

namespace L2._5.Part8
{
    public class Program
    {
        public static int Square(int x , int y)
        {
            if(y==0)
                return 1 ;

            int r = 1 ;
            for(int i=0 ; i<y ; i++)
                r *= x ;

            return r ;
        }

        public static double Average(double n)
        {
            if(n==0)
                Console.WriteLine("None");

            double sum = 0 ;
            for(int i=1 ; i<n+1 ; i++)
                sum += Square(i,2);

            double average = sum/n ;
            return average ;
        }

        static void Main(string[] args)
        {
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Average(N));
        }
    }
}


