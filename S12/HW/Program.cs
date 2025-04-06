namespace HW;

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(4,9,2),
            new Car(4,9,4),
            new Bicycle(0,8,5),
            new Bicycle(8,10,4)
        };

        for(int i=0 ; i<vehicles.Length ; i++)
        {
            Console.WriteLine("acceleration : " + vehicles[i].acceleration());
            Console.WriteLine("capacity : " + vehicles[i].capacity());
            Console.WriteLine("number of wheels : " + vehicles[i].wheel());
            Console.WriteLine();
        }
    }
}
