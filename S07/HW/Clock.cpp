#include<iostream>
#include<Windows.h>
#include<string>
using namespace std;

class KeepTime
{
    
    public:
    string m_procname ;
    unsigned long long start ;
    
        KeepTime(const string& name)
        :m_procname(name)
        {
           start = GetTickCount64();
        }

        ~KeepTime()
        {
            unsigned long long end = GetTickCount64();
            cout << end - start << endl ;
        }
};

int main()
{
    KeepTime t("seconds in a year");
    int s = 0 ;
    for(int i=0 ; i<365*24*3600 ; i++)
        s++ ;
}