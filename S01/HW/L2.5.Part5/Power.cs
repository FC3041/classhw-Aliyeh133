namespace L2._5.Part5
{
    public class Program
    {
        public static int Result(int x , int y)
        {
            if(y==0)
                return 1 ;

            int r = 1 ;
            for(int i=0 ; i<y ; i++)
                r *= x ;

            return r ;
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Result(x,y));
        }
    }
}


