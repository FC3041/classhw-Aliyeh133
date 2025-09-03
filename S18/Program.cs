namespace S18;

class Student
{
    public string? Firstname ;
    public Nullable<int> Id ;
}

class Program
{
    static void main(string[] args)
    {
        static void print_student(Student? student)
        {
            if( student != null )
            {
                Console.WriteLine($"{student.Firstname}");
                if( student.Id.HasValue)
                    Console.WriteLine(student.Id.Value);
            }
        }

        Student s = new Student(){Firstname = "sara" , Id = 1} ;
        print_student(s);
    }
}
