public class Program2
{
    public static void Do1(object obj)
    {
        try
        {
            ConsoleColor c = (ConsoleColor) obj ;
            while(true)
            {
                ConsoleColor pc = Console.ForegroundColor ;
                Console.ForegroundColor = c ;
                Console.WriteLine(c.ToString());
                Console.ForegroundColor = pc ;
                Thread.Sleep(500);
            }
        }
        catch
        {
            Environment.Exit(-1);
        }
    }
    public static void Main(string[] args)
    {
        // Do1(); // only Do1 will be written ! Stack over flow will
        //        // not occure ! An endless loop !!

        Thread t = new Thread(Do1);
        t.Start(ConsoleColor.Blue);

        Thread t1 = new Thread(Do1);
        t1.Start(ConsoleColor.Green);

        while(true)
        {
            Console.WriteLine("Main");
            Thread.Sleep(500);
        }
    }
}