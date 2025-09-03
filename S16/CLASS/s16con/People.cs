class Citizen
{
    public string Firstname{get;set;}
    public string Lastname{get;set;}
    public bool IsMale{get;set;}
    public int PostalCode {get; set;}
    public int NationalId{get; set;}

    public Citizen(string fname , string lname , int id , bool ismale , int postalCode)
    {
        this.Firstname = fname;
        this.Lastname = lname;
        this.NationalId = id;
        this.IsMale = ismale;
        this.PostalCode = postalCode;
    }

    public Citizen(string fname , string lname , int id , bool ismale)
    : this(fname,lname,id,ismale,0){}

    // public Citizen(){}

    public override string ToString()
    {
        return $"{base.ToString()} : {this.Firstname} {this.Lastname} - {this.NationalId}" ;
    }
}

class Student : Citizen
{
    public int StdId {get;set;}
    public string Major{get;set;}
    public bool IsPaying{get;set;}
    public Student(string fname , string lname , int id , bool ismale , string major , int stdid , bool ispayingmoney)
    : base(fname,lname,id,ismale)
    {
        this.StdId = stdid;
        this.Major = major;
        this.IsPaying = ispayingmoney;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {this.Major} - {this.StdId}" ;
    }

    public void Register(string course)
    {
        Console.WriteLine($"{this.Firstname} {this.Lastname} is registered in {course}");
    }
}

// class Teacher : Citizen
// {
//     TODO1 Salary
//     TODO2 Rating
//     TODO3 EmployeeId
// }

class GradStudent : Student
{
    public string Minor{get; set;}
    public string ThesisTitle{get; set;}
    public GradStudent(string fname , string lname , int id , bool ismale ,
                     string major , int stdid , bool ispayingmoney , string minor , string thesisTitle)
    : base(fname,lname,id,ismale,major,stdid,ispayingmoney)
    { 
        Minor = minor ;
        ThesisTitle = thesisTitle ;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {this.Minor}";
    }

    public new void Register(string course)
    {
        Console.WriteLine($"{this.Firstname} {this.Lastname} intro to prof in {course}");
    }
}