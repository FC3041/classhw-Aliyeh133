namespace L2._6.Part7
{
    public class Program
    {
        public static void Numbers(int n)
        {
            for(int a=0 ; a<n ; a++)
            {
                for(int b=0 ; b<n ; b++)
                {
                    for(int c=0 ; c<n ; c++)
                    {
                        if((a<b) && (b<c) && (a*a + b*b == c*c))
                            Console.WriteLine(a + "," + b + "," + c);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Numbers(100);
        }
    }
}


