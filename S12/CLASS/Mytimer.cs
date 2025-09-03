using System.Diagnostics;

public class Mytimer : IDisposable
{
    public string name ;
    private Stopwatch sw = new Stopwatch() ;
    public Mytimer(string rm)
    {
        name = rm ;
        sw.Start();
    }

    public void Dispose()
    {
        sw.Stop();
        Console.WriteLine($"{this.name},{this.sw.Elapsed.ToString()}");
    }

    public void printsw()
    {
        System.Console.WriteLine($"{this.name}");
    }
}