namespace L2._5.Part7
{
    public class Program
    {
        public static double Average(double n)
        {
            if(n==0)
                Console.WriteLine("None");

            double sum = 0 ;
            for(int i=0 ; i<n ; i++)
                sum += i*i ;
            

            double average = sum/n ;
            return average ;
        }

        static void Main(string[] args)
        {
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Average(N));
        }
    }
}


