using System.Data.Common;

namespace L2._7.Part9
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
                return d ;

            int day = d ;
            for(int i=1 ; i<m ; i++)
                day += DaysInMonth(y,i);
            return day ;
        }

        public static string DaysOfWeek(int n)
        {
            if(n==1)
                return "Sunday" ;

            if(n==2)
                return "Monday" ;

            if(n==3)
                return "Tuesday" ;

            if(n==4)
                return "Wednesday" ;

            if(n==5)
                return "Thursday" ;

            if(n==6)
                return "Friday" ;

            return "Saturday" ;            
        }

        static void Main(string[] args)
        {
            int D = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());

            if(M==1 & D<=4)
                Console.WriteLine(DaysOfWeek(D+3));
            
            else
            {
                int days = DaysBefore(D,M,2014);
                int remain = (days-4)%7 ;
                Console.WriteLine(DaysOfWeek(remain));
            }
        }
    }
}