using System.Net.Http.Headers;

public class Student
{
    public string fname;
    public string lname;
    public int NID;

    public Student(string fn,string ln,int id)
    {
        fname = fn ;
        lname = ln ;
        NID = id ;
    }

    public void PrintStudent()
    {
        Console.WriteLine($"{this.fname},{this.lname},{this.NID}");
    }

    public bool Ishigher(Student std)
    {
        return this.NID > std.NID ;
    }
}