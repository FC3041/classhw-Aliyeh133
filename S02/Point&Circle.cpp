#include<iostream>
#include<math.h>

using namespace std;

class Circle
{
    public:
        double x ;
        double y ;
        double r ;

    Circle(double x0 , double y0 , double r0)
    {
        x = x0 ;
        y = y0 ;
        r = r0 ;
    };
};


class Point
{
    public:
        double x ;
        double y ;

    Point(double x0 , double y0)
    {
        x = x0 ;
        y = y0 ;
    };
};


void distance(Circle c , Point p)
{
    double dx = c.x - p.x ;
    double dy = c.y - p.y ;
    double d = sqrt(dx*dx + dy*dy);

    if(d<c.r)
        cout << "IN  d:" << d << endl ;

    if(d==c.r)
        cout << "ON  d:" << d << endl ;

    if(d>c.r)
        cout << "OUT  d:" << d << endl ;
}


int main()
{
    double x0 ;
    cin >> x0 ;

    double y0 ;
    cin >> y0 ;

    double r0 ;
    cin >> r0 ;

    Circle c(x0,y0,r0);


    double x1 ;
    cin >> x1 ;

    double y1 ;
    cin >> y1 ;

    Point p(x1,y1);

    distance(c,p);
}