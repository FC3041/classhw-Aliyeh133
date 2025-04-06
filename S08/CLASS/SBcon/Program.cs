using System.Security.Cryptography;

namespace SBcon;

public class Program
{
    public static int add(int a,int b)
    {
        return a+b ;
    }

    public static void prepend_user(string s , out string sout)
    {
        sout = "user:" + s ;
    }

    public static void reverse(string s , out string srev)
    {
        srev = "" ;
        foreach(char c in s)
            srev = c + srev ;
    }

    static void Main1(string[] args)
    {
        // for(int i=0 ; i<args.Length ; i++)
        // {
        //     System.Console.WriteLine($"args{i}:{args[i]}");
        // }
        string name = "ali" ;
        string srev;
        reverse(name , out srev);
        System.Console.WriteLine(srev);
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine(Student.StudentCount);
        Student s1 = new Student("zoha",1232);
        System.Console.WriteLine(Student.StudentCount);
        System.Console.WriteLine(s1.name);
    }
}