namespace L2._5.Part6
{
    public class Program
    {
        public static void FindX(double a , double b , double c)
        {
            double m = b*b - 4*a*c ;
            double delta = Math.Pow(m,0.5);

            if(m<0)
                Console.Write("No Answer") ;

            if(m==0)
            {
                double x = -b/2*a ;
                Console.Write(x) ;
            }

            if(m>0)
            {               
                double X1 = (-b-delta)/2*a ;
                double X2 = (-b+delta)/2*a ;
                Console.WriteLine(X1) ;
                Console.Write(X2) ;
            }

        }

        static void Main(string[] args)
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            FindX(A,B,C);
        }
    }
}


