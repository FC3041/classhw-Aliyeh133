public interface Vehicle
{
    public int capacity();
    public double acceleration();
    public int wheel();
}

class Car : Vehicle
{
    public double v0 ;
    public double v1 ;
    public double t ;

    public Car(double V0 , double V1 , double T)
    {
        v0 = V0 ;
        v1 = V1 ;
        t = T ;
    }

    public double acceleration()
    {
        return (v1-v0)/t ;
    }

    public int capacity()
    {
        return 4 ;
    }

    public int wheel()
    {
        return 4 ;
    }
}

class Bicycle : Vehicle
{
    public double v0 ;
    public double v1 ;
    public double t ;

    public Bicycle(double V0 , double V1 , double T)
    {
        v0 = V0 ;
        v1 = V1 ;
        t = T ;
    }

    public double acceleration()
    {
        return (v1-v0)/t ;
    }

    public int capacity()
    {
        return 1 ;
    }

    public int wheel()
    {
        return 2 ;
    }
}