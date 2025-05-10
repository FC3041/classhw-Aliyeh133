#include<iostream>
#include<math.h>

using namespace std;

class Circle
{
    public:
        double x ;
        double y ;

    Circle(double x0 , double y0)
    {
        x = x0 ;
        y = y0 ;
    };

    double circle_distance(Circle c2)
    {
        double dx = x - c2.x ;
        double dy = y - c2.y ;
        return sqrt(dx*dx + dy*dy);
    };
};


int main()
{
    double x0 ;
    cin >> x0 ;

    double y0 ;
    cin >> y0 ;

    Circle c1(x0,y0);


    double x1 ;
    cin >> x1 ;

    double y1 ;
    cin >> y1 ;

    Circle c2(x1,y1);

    double d = c1.circle_distance(c2);
    cout << d << endl ;
}