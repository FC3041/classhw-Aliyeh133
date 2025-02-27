using System.Reflection;

namespace L2._3
{
    public class Program
    {
        public static void Cone(int x)
        {
            for(int n=0 ; n<x+1 ; n++)
                Console.Write(" ");               

            Console.WriteLine("^");

            for(int k=0 ; k<x ; k++)
            {
                for(int i=0 ; i<x-k ; i++)
                    Console.Write(" ");

                for(int j=0 ; j<k+1 ; j++)
                    Console.Write("/");             

                Console.Write("|");

                for(int m=0 ; m<k+1 ; m++)
                    Console.Write("\\");                      

                Console.WriteLine();
            }

        }

        public static void Line(int x)
        {
            Console.Write("+");

            for(int o=0 ; o<(2*x)+1 ; o++)
                Console.Write("-");

            Console.Write("+");
            Console.WriteLine();          
        }

        public static void Body(int x,int y)
        {
            for(int p=0 ; p<y ; p++)
            {
                Console.Write("+");
    
                for(int o=0 ; o<(2*x)+1 ; o++)
                    Console.Write("*");

                Console.Write("+");
                Console.WriteLine();           
            }
        }


        static void Main(string[] args)
        {
            // w%2=1  
            int w = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int u = Convert.ToInt32(Console.ReadLine());   

            Cone(w);
            Line(w);
            for(int t=0 ; t<u ; t++)
            {
                Body(w,h);
                Line(w);
            }
            Cone(w);
        }
    }    
}
