namespace L2._5.Part1
{
    public class Program
    {
        public static double Celsius(double f)
        {
            double C = Math.Round((f-32)*5/9 , 2) ;
            return C ;
        }

        static void Main(string[] args)
        {
            double F = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Celsius(F));
        }
    }
}


