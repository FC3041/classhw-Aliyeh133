using System.Dynamic;

namespace s16con;

class Program
{
    static void Print_Persons(Citizen[] cs)
    {
        foreach(var c in cs)
            Console.WriteLine(c.ToString());
    }
    static void Main(string[] args)
    {
        Citizen k = new Citizen("ali","alavi",1,true);
        Student s = new Student("alie","naghavi",088,false,"computer",403,false);
        GradStudent gs = new GradStudent("reza" , "razavi" , 093 , true , "Math" , 401 , false , "Calculus" , "Integral");
        Console.WriteLine(k);
        Console.WriteLine(s);
        Console.WriteLine(gs);

        Console.WriteLine("-------------------------");
        
        Citizen[] citizens = new Citizen[]{k,s,gs};
        Print_Persons(citizens);

        Console.WriteLine("-------------------------");

        s.Register("Numerical");
        gs.Register("Numerical2");

    }
}
