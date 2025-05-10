namespace L2._6.Part1
{
    public class Program
    {
        public static bool LeapYear(int year)
        {
            if(year%100 == 0 & year%400 == 0)
                return true ;

            if(year%4 == 0 & year%100 != 0)
                return true ;

            return false ;
        }

        static void Main(string[] args)
        {
            for(int i=0 ; i<8 ; i++)
            {
                int Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Year + "  " + LeapYear(Year));
            }
        }
    }   
}

