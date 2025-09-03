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

    double circle_perimeter()
    {
        double P = 2*r*M_PI ;
        return P ;
    };

    double circle_area()
    {
        double S = r*r*M_PI ;
        return S ;
    };
};


int main()
{
    double x ;
    cin >> x ;

    double y ;
    cin >> y ;

    double r ;
    cin >> r ;

    Circle c1(x,y,r);
    double p = c1.circle_perimeter();
    cout << p << endl ;

    double s = c1.circle_area();
    cout << s << endl ;
}