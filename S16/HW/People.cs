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

    public virtual void HomeTown(string nameofcity)
    {
        Console.WriteLine($"{this.Firstname} was born in {nameofcity}");
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

    public override void HomeTown(string nameofcity)
    {
        Console.WriteLine($"{this.Firstname}'hometown is {nameofcity} ");
    }
}

class Teacher : Citizen
{
    public int Salsry {get; set;}
    public int Rating{get; set;}
    public int EmployeeId{get; set;}
    public Teacher(string fname , string lname , int id , bool ismale, int salary , int rate , int employeeId)
    : base(fname,lname,id,ismale) 
    {
        Salsry = salary ;
        Rating = rate ;
        EmployeeId = employeeId ;
    }
}

class GradStudent : Student
{
    public string Minor{get; set;}
    public string ThesisTitle{get; set;}
    public GradStudent(string fname , string lname , int id , bool ismale ,
                     string major , int stdid , bool ispayingmoney , string minor , string thesisTitle)
    : base(fname,lname,id,ismale,major,stdid,ispayingmoney) //base of this class is "Student"
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