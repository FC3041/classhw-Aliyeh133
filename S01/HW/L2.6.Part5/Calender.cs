namespace L2._6.Part5
{
    public class Program
    {
        public static void Month(int n)
        {
            if(n==1)
                Console.WriteLine("January");

            if(n==2)
                Console.WriteLine("February");

            if(n==3)
                Console.WriteLine("March");

            if(n==4)
                Console.WriteLine("April");

            if(n==5)
                Console.WriteLine("May");

            if(n==6)
                Console.WriteLine("June");

            if(n==7)
                Console.WriteLine("July");

            if(n==8)
                Console.WriteLine("August");

            if(n==9)
                Console.WriteLine("September");

            if(n==10)
                Console.WriteLine("October");

            if(n==11)
                Console.WriteLine("November");

            if(n==12)
                Console.WriteLine("December");

            if(n>12)
                Console.WriteLine("None");

        }

        static void Main(string[] args)
        {
            for(int i=1 ; i<13 ; i++)
            {
                Console.Write(i + " ");
                Month(i);
            }
        }
    }
}


