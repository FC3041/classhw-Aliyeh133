using System.Diagnostics;
namespace L2._9.Part2
{
    public class Program
    {
        public static bool IsPrime(int a)
        {
            Debug.Assert(a>0);

            if(a==1)
                return false ;

            if(a==2)
                return true ;

            for(int i=2 ; i<a ; i++)
            {
                if(a%i == 0)
                    return false ;
            }
            return true ;
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(x));
        }
    }
}


