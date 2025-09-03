#include<iostream>
using namespace std;

class String
{
    public:
        char* m_str ;
        int m_size ;


    String(char* string)
    {
        m_size = size_of_str(string);
        m_str = new char[sizeof(char)*m_size] ;

        for(int i=0 ; string[i] != 0 ; i++)
            m_str[i] = string[i] ;
    }

    
    int size_of_str(char* str)
    {
        int size = 0 ;
        for(int i=0 ; str[i] != '\0' ; i++)
            size += 1 ;
        return size ;
    }

    void join_str(String str2)
    {
        str2.m_size = size_of_str(str2.m_str) ;

        char* newstr = new char[sizeof(char)*(m_size+str2.m_size)] ;

        for(int k=0 ; k<m_size ; k++)
            newstr[k] = m_str[k] ;

        for(int l=0 ; l<str2.m_size ; l++)
            newstr[l+m_size] = str2.m_str[l] ;

        delete(m_str);
        newstr[m_size+str2.m_size] = '\0' ;
        m_str = newstr ;
    }

    void print_string()
    {
        for(int i=0 ; m_str[i] != '\0' ; i++)
            cout << m_str[i] ;
    }
};


int main()
{
    char str1[7] = "Hello." ;
    char str2[11] = "I am Ali." ;
    String s1(str1);
    String s2(str2);
    s1.join_str(s2);
    s1.print_string();
}