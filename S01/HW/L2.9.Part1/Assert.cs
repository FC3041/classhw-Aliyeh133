using System.Diagnostics;

namespace L2._9.Part1
{
    public class Program
    {
        public static int Factorial(int n)
        {
            Debug.Assert(n>=0);

            if(n==1 | n==0)
                return 1 ;

            int i = 1 ;
            int s = 1 ;
            while(i<n+1)
            {
                s *= i ;
                i++ ;
            }

            Debug.Assert(s>=0);
            return s ;
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(x));  
        }
    }
}



