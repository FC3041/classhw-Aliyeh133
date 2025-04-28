using System.Dynamic;

namespace HW;

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
        Teacher t = new Teacher("shahrzad","rasouli",0880423,false,10,100,1);
        Console.WriteLine(k);
        Console.WriteLine(s);
        Console.WriteLine(gs);
        Console.WriteLine(t);

        Console.WriteLine("-------------------------");
        
        Citizen[] citizens = new Citizen[]{k,s,gs,t};
        Print_Persons(citizens);

        Console.WriteLine("-------------------------");

        s.Register("Numerical");
        s.HomeTown("Tehran");
        gs.Register("Numerical2");

    }
}

