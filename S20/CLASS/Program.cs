using System.Collections.Specialized;
using System.Numerics;

namespace S20;

class Program
{
    public static (int , int , double) AnalyzeList(List<int> nums)
    {
        if( nums == null || nums.Count == 0)
            throw new Exception("List must not be empty !");
        
        int max = nums.Max();
        int min = nums.Min();
        double avg = nums.Average();
        avg = Math.Round(avg,2);

        return(min , max , avg);
    }

    static void Main(string[] args)
    {
        Tuple<string,int> t1 = new Tuple<string, int>("Ali",40);
        Console.WriteLine($"{t1.Item1} is {t1.Item2}");

        var t2 = new Tuple<string,int,int>("Kim",13,123);
        Console.WriteLine($"{t2.Item1} - {t2.Item2} - {t2.Item3}");

        var t3 = Tuple.Create("Hana",5); // =  Tuple.Create<string,int>("Hana",5);
        Console.WriteLine($"{t3.Item1} is {t3.Item2}");

        MyTuple<double,string> t4 = new MyTuple<double,string>(12.7 , "Ok");
        Console.WriteLine($"{t4.Item1} is {t4.Item2}");

        ValueTuple<string,int> t5 = new ValueTuple<string,int>("Yes",7); // this id value type but the others are reference type !
        Console.WriteLine($"{t5.Item1} is {t5.Item2}");

        List<int> nums = new List<int> {2,5,7,9,10,0,7};
        Console.WriteLine(AnalyzeList(nums));

    }



    static void Main2(string[] args)
    {
        string name = "computer" ;
        string name1 = name.TitleCase();
        Console.WriteLine(name1);

        string text = "uriu98346tfgajh320" ;
        Console.WriteLine(text.NumberOfNums());
    }



    static void Main1(string[] args)
    {
        int x = 5 ;
        double y = 6.8 ;

        y = x ; //implicit
        x = (int)y ; //emplicit : data will lose some parts !

        CoomplexNumber c1 = new CoomplexNumber (2,6) ;
        CoomplexNumber c2 = new CoomplexNumber (7,9) ;

        y = c1 ; //implicit
        c2 = y ;

        c2.Print_Number();
    }



    static void Main0(string[] args)
    {
        CoomplexNumber c1 = new CoomplexNumber (2,6) ;
        CoomplexNumber c2 = new CoomplexNumber (7,9) ;
        CoomplexNumber c3 = c1 + c2 ;

        c3.Print_Number();
        Console.WriteLine(c3[true]);     
        Console.WriteLine(c3[1]);     
    }
}
