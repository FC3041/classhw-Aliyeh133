namespace CLASS;

class Program
{
    static void Main(string[] args)
    {
        for(int i=0 ; i<3 ; i++)
        {
            Console.Write("name? ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello" + " " + name + "!");
        }
    }
}
