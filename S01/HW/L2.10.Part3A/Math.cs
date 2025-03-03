namespace L2._10.Part3A
{
    public class Program
    {
        public static double Abso(double x)
        {
            if(x>=0)
                return x ;
            return -x ;
        }

        public static bool Close(double x,double y,double closeness)
        {
            while((Abso(x-y) <= closeness*Abso(x)) && (Abso(x-y) <= closeness*Abso(y)))
                    return true ; 
            return false ;
        }



        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write(Close(x,y,c));
        }
    }
}


