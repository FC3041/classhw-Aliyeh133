namespace L2._2
{
    public class Program
    {
        public static void Cone()
        {
            Console.WriteLine("    ^");
            Console.WriteLine(@"   /|\");
            Console.WriteLine(@"  //|\\");
            Console.WriteLine(@" ///|\\\");
        }

        public static void Line()
        {
            Console.WriteLine("+-------+");
        }

        public static void Body()
        {
            Console.WriteLine("+*******+");
            Console.WriteLine("+*******+");
            Console.WriteLine("+*******+");
            Console.WriteLine("+*******+");
        }

        static void Main(string[] args)
        {
            Cone();
            Line();
            Body();
            Line();
            Body();
            Line();
            Cone();
        }
    }    
}
