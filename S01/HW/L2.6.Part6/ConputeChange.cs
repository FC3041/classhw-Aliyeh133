namespace L2._6.Part6
{
    public class Program
    {
        public static void Change(int d,int n)
        {
            int C = d*100-n ;
            int Q = C/25 ;
            int D = (C-Q*25)/10 ;
            int N = (C-Q*25-D*10)/5 ;
            int P = C-Q*25-D*10-N*5 ;
            Console.WriteLine(Q + " " + "quarter");
            Console.WriteLine(D + " " + "dime");
            Console.WriteLine(N + " " + "nickel");
            Console.WriteLine(P + " " + "penny");
        }

        static void Main(string[] args)
        {
            int Dollar = Convert.ToInt32(Console.ReadLine());
            int Number = Convert.ToInt32(Console.ReadLine());
            Change(Dollar,Number);
        }
    }
}


