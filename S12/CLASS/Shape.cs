public interface IShape
{
    public double Area();
    public double Perimeter();
}

class Rectangle : IShape
{
    public double L;
    public double W;

    public Rectangle(double ll , double ww)
    {
        L = ll ;
        W = ww ;
    }

    public double Area()
    {
        return L*W ;
    }

    public double Perimeter()
    {
        return 2*(L+W) ;
    }
}


class Circle : IShape
{
    public double radius;

    public Circle(double r)
    {
        radius = r ;
    }

    public double Area()
    {
        return radius*radius*Math.PI ;
    }

    public double Perimeter()
    {
        return 2*radius*Math.PI ;
    }
}