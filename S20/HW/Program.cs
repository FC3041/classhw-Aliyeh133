using System.Collections.Specialized;

namespace HW;

class Program
{
    static void Main(string[] args)
    {
        string s = "sihhYIOP" ;
        string En_s = s.Encoder();
        string De_s = En_s.Decoder();
        Console.WriteLine(En_s);
        Console.WriteLine(De_s);
    }
}
