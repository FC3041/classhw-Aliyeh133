namespace L2._7.Part6
{
    public class Program
    {
        public static int Days(int n)
        {
            if(n==1 | n==3 | n==5 | n==7 | n==8 | n==10 | n==12)
                return 31 ;

            if(n==4 | n==6 | n==9 | n==11)
                return 30 ;

            return 28 ;

        }

        static void Main(string[] args)
        {
            int MonthNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(Days(MonthNum));
        }
    }
}


