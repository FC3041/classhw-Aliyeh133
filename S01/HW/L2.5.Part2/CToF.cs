namespace L2._5.Part2
{
    public class Program
    {
        public static double Fahrenheit(double c)
        {
            double F = Math.Round((c*9/5)+32 , 2);
            return F ;
        }
        static void Main(string[] args)
        {
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Fahrenheit(C));
        }
    }
}


