namespace L2._7.Part8
{
    public class Program
    {
        public static int DaysInMonth(int year , int n)
        {
            if(n==1 | n==3 | n==5 | n==7 | n==8 | n==10 | n==12)
                return 31 ;

            if(n==4 | n==6 | n==9 | n==11)
                return 30 ;

            if(n==2)
            {
                if((year%100 == 0 & year%400 == 0)|(year%4 == 0 & year%100 != 0))
                    return 29 ;
            }
            return 28 ;

        }

        public static int DaysBefore(int d , int m , int y)
        {
            if(m==1)
                return d-1 ;

            int day = d-1 ;
            for(int i=1 ; i<m ; i++)
                day += DaysInMonth(y,i);
            return day ;
        }

        static void Main(string[] args)
        {
            int D = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DaysBefore(D,M,Y));
        }
    }
}


