#include<iostream>
#include<math.h>
using namespace std;

class Point
{
    public:
        double m_x ;
        double m_y ;
    
    Point(double x , double y):m_x(x),m_y(y){};
    Point(){};

    double DistanceTo(Point p)
    {
        double dif_x = m_x - p.m_x ;
        double dif_y = m_y - p.m_y ;
        return sqrt(dif_x*dif_x + dif_y*dif_y);
    }

    void print_point()
    {
        cout << "x : " << m_x << " y : " << m_y << endl ;
    }
};


class Circle
{
    public:
        Point m_o ;
        double m_r ;

    // Circle(const Point& o , double r)
    // {
    //     m_o = o ;
    //     m_r = r ;
    // }

    Circle(const Point& o , double r):m_o(o),m_r(r){};
    Circle(){};

    double Distance(Circle c)
    {
        return DistanceTo(c.m_o);
    }

    double DistanceTo(Point p)
    {
        return p.DistanceTo(m_o);
    }
};

int main()
{
    Point p1 ;
    Point p2(4,7);
    Circle c1(p1,12.3);
    Circle c2(Point(1,5),12);   
    cout << c1.Distance(c2) << endl ;
    cout << c1.DistanceTo(p1) << endl ;
    cout << p1.DistanceTo(p2) << endl ;
}