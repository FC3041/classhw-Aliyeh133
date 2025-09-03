namespace S17con;

class Program
{
    static void Main(string[] args)
    {
        Point[] points = new Point[3]{new Point(1,1) , new Point(1,3) , new Point(5,2)};
        List<Square> squares = new List<Square>();
        foreach(var p in points)
            foreach(var l in new int[]{3,5,7})
                squares.Add( new Square(p,l) );

        foreach(var p in points)
        {
            p.X = 0 ;
            p.Y = 0 ;
        }

        foreach(var s in squares)
        {
            s.Draw();
            Console.WriteLine("----------------");
        }

        Point p1 = new Point(5,2);
        Square s1 = new Square(p1,3);
        s1.Draw();
        p1.X = 6 ; 
        p1.Y = 6 ;
        Square s2 = new Square(p1,7);
        s2.Draw();
    }
}
