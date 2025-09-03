#include<iostream>
using namespace std;

class MyStr
{
    int m_size ;
    char* m_PChars ;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i ;
        for(i=0 ; chars[i] != 0 ; i++)
            m_size = i+1 ;
    }
};