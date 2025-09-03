namespace L2._5.Part4
{
    public class Program
    {
        public static int Factorial(int x)
        {
            if(x==1 | x==0)
                return 1 ;

            int i = 1 ;
            int s = 1 ;
            while(i<x+1)
            {
                s *= i ;
                i++ ;
            }
            return s ;
        }


        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            
            for(int j=0 ; j<x+1 ; j++)
                Console.WriteLine(j + " " + Factorial(j));    
        }
    }
}


