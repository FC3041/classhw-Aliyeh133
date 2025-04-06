
namespace CLASS;

class Program
{
    public static void Mysort(Student[] plist)
    {
        for(int i=0 ; i<plist.Length ; i++)
        {
            for(int j=i+1 ; j<plist.Length ; j++)
            {
                if(plist[i].Ishigher(plist[j]))
                    swap(plist,i,j);
            }
        }
    }

    private static void swap(Student[] plist, int i, int j)
    {
        Student temp = plist[i] ;
        plist[i] = plist[j] ;
        plist[j] = temp ;
    }

    static void Main(string[] args)
    {
        Student[] students = new Student[]
        {
            new Student("ali","ahamdi",234),
            new Student("Zahra","Mohammadi",1234),
            new Student("reza","nejati",67)
        };

        for(int i=0 ; i<students.Length ; i++)
            students[i].PrintStudent();

        Mysort(students);

        Console.WriteLine("-----------------------");
        for(int i=0 ; i<students.Length ; i++)
            students[i].PrintStudent();
    
        }


    static void Main2(string[] args)
    {
        People p0 = new People("Zahra","Mohammadi",1234);                    
        People p1 = new People("Ali","Seyfi",403);
        People p2 = new People("Hossein","Karimi",12);
        People p3 = new People("Reza","Ahmadi",698);

        List<People> peoples = new List<People>();

        peoples.Add(p0);
        peoples.Add(p1);
        peoples.Add(p2);
        peoples.Add(p3);

        // People[] peoples = new People[]
        // {
        //     new People("Zahra","Mohammadi",1234),
        //     new People("Ali","Seyfi",403),
        //     new People("Hossein","Karimi",12),
        //     new People("Reza","Ahmadi",698)
        // };

        for(int i=0 ; i<peoples.Count ; i++)
            Console.WriteLine(peoples[i].fname);

        peoples.Sort();

        Console.WriteLine();
        for(int i=0 ; i<peoples.Count ; i++)
            Console.WriteLine(peoples[i].fname);

    }


    static void Main1(string[] args)
    {
        IShape[] shapes = new IShape[]
        {
            new Rectangle(2,3),
            new Circle(8),
            new Rectangle(7,9),
            new Circle(5)
        };

        double Area_sum = 0 ;
        double Perimeter_sum = 0 ;

        for(int i=0 ; i <shapes.Length ; i++)
        {
            Area_sum += shapes[i].Area();
            Perimeter_sum += shapes[i].Perimeter();
        }

        Console.WriteLine(Area_sum);
        Console.WriteLine(Perimeter_sum);
    }

    static void Main0(string[] args)
    {
        using(Mytimer time = new Mytimer("Add 0 to 100"))
        {
            int sum = 0 ;
            for(int i=0 ; i<100 ; i++)
                sum += i ;

            Console.WriteLine(sum);
        }
    }
}
