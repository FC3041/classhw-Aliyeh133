namespace L2._7.Part2
{
    public class Program
    {
        public static int Factorial(int a)
        {
            int sum = 1 ;
            for(int i=1 ; i<a+1 ; i++)
                sum *= i ;

            return sum ;
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            for(int j=1 ; j<N+1 ; j++)
                Console.WriteLine(j + " " + Factorial(j));
        }
    }
}


