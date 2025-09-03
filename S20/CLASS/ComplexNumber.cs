public class CoomplexNumber
{
    public double Re;
    public double Im;
    public CoomplexNumber(double r , double i)
    {
        Re = r ;
        Im = i ;
    }

    public void Print_Number()
    {
        Console.WriteLine($"{this.Re}+{this.Im}i");
    }

    public static CoomplexNumber operator+(CoomplexNumber c1 , CoomplexNumber c2)
    {
        return new CoomplexNumber(c1.Re+c2.Re , c1.Im+c2.Im);
    }

    public double this[int index]
    {
        get
        {
            if(index == 0)
                return this.Re ; 
            else if(index == 1)
                return this.Im ;
            else
                throw new IndexOutOfRangeException("index out of range!");

        }

        set
        {
            if(index == 0)
                 this.Re = value ; 
            else if(index == 1)
                 this.Im = value ;
            else
                throw new IndexOutOfRangeException("index out of range!");            
        }
    }

    public double this[bool index]
    {
        get
        {
            if(index == true)
                return this.Re ; 
            else if(index == false)
                return this.Im ;
            else
                throw new IndexOutOfRangeException("index out of range!");

        }

        set
        {
            if(index == true)
                 this.Re = value ; 
            else if(index == false)
                 this.Im = value ;
            else
                throw new IndexOutOfRangeException("index out of range!");            
        }
    }

    // public static explicit operator double(CoomplexNumber c)
    // {
    //     return c.Re ;
    // }

    public static implicit operator double(CoomplexNumber c)
    {
        return c.Re ;
    }

    public static implicit operator CoomplexNumber(double a)
    {
        return new CoomplexNumber(a,a) ;
    }
}