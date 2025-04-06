#include<iostream>
using namespace std;

class Student
{
    public :
        char m_name[20];
        int m_stdno;
};

int main()
{
    Student s;
    s.m_name[0] = 'A' ;
    s.m_name[1] = 0 ;
    s.m_stdno = 403521 ;
    cout << s.m_name << endl ;
}