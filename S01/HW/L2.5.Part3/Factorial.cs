namespace L2._5.Part3
{
    public class Program
    {
        public static int Factorial(int x)
        {
            if(x==0 | x==1)
                return 1 ;

            int i = 1 ;
            int s = 1 ;
            while(i<x+1)
            {
                s *= i  ;
                i++ ;
            } 

            return s ;
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(x));
        }
    }
}

