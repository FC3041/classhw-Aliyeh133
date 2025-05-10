namespace L2._7.Part3
{
    public class Program
    {
        public static bool Divisible(int a , int b)
        {
            if(a%b == 0)
                return true ;
            return false ;
        }

        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write(Divisible(A,B));
        }
    }
}


