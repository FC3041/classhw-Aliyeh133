namespace L2._7.Part4
{
    public class Program
    {
        public static bool IsPrime(int n)
        {
            if(n==1)
                return false ;

            if(n==2)
                return true ;

            for(int i=2 ; i<n ; i++)
            {
                if(n%i == 0)
                    return false ;
            }
            return true ;
        }


        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write(IsPrime(N));
        }
    }
}


