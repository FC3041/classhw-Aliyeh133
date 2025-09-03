namespace L2._7.Part7
{
    public class Program
    {
        public static int DaysInMonth(int y , int m)
        {

            if(m==1 | m==3 | m==5 | m==7 | m==8 | m==10 | m==12)
                return 31 ;

            if(m==4 | m==6 | m==9 | m==11)
                return 30 ;

            if(m==2 & ((y%100 == 0 & y%400 == 0) | (y%4 == 0 & y%100 != 0)))
                return 29 ;

            return 28 ;
        }

        static void Main(string[] args)
        {
            int MonthNum = Convert.ToInt32(Console.ReadLine());
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.Write(DaysInMonth(Year,MonthNum));
        }
    }
}


