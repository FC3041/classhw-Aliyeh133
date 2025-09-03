using System.Drawing;
using System.Runtime.Intrinsics;

class Point
{
    public double X {get; set;}
    public double Y {get; set;}

    public static Point operator+(Point p1 , Point p2)
    {
        p1.X += p2.X ;
        p1.Y += p2.Y ;
        return p1 ;
    }

    public Point(double x , double y)
    {
        X = x ;
        Y = y ;
    }

    public override string ToString() => $"[{X},{Y}]" ;

    public Point Clone()
    {
        return new Point(this.X , this.Y) ;
    }
}

abstract class Shape
{
    private string Name;
    protected Point[] points;
    public void Move(Point d)
    {
        for(int i=0 ; i<points.Length ; i++)
            points[i] += d ;
    }

    public void Draw()
    {
        for(int i=1; i<points.Length; i++)
            Console.WriteLine($"line({points[i-1]} => {points[i]})"); 
    }

    public abstract double GetArea();
}

class Square : Shape
{
    public double Len{get; set;}
    public Square(Point s , double len)
    {
        this.points = new Point[4] ;
        this.points[0] = s.Clone() ;
        this.points[1] = new Point(s.X + len, s.Y);
        this.points[2] = new Point(s.X + len, s.Y + len);
        this.points[3] = new Point(s.X , s.Y + len);
        this.Len = len;
    }

    public override double GetArea() => Len*Len ;
}