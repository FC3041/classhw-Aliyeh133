#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }

    int lenStr(char* string)
    {
        int len = 0 ;
        for(int i=0 ; string[i] != 0 ; i++)
            len += 1 ;
        return len+1 ;
    }

    void add(MyStr str2)
    {
        str2.m_size = lenStr(str2.m_PChars) ;

        char* newstr = new char[sizeof(char)*(m_size+str2.m_size-1)] ;

        for(int k=0 ; k<m_size-1 ; k++)
            newstr[k] = m_PChars[k] ;

        for(int l=0 ; l<str2.m_size ; l++)
            newstr[l+m_size] = str2.m_PChars[l] ;

        delete(m_PChars);
        newstr[m_size+str2.m_size-1] = '\0' ;
        m_PChars = newstr ;
    }

    bool check_substr(MyStr str)
    {
        int index = 0 ;
        if( str.m_size > m_size)
            return false ;
        
        if( str.m_size <= m_size)
        {
            for(int i=0 ; i<m_size ; i++)
            {
                if(str.m_PChars[0] == m_PChars[i])
                {
                    for(int j=1 ; j<str.m_size ; j++)
                    {
                        if(str.m_PChars[j] == m_PChars[i+1])
                        {
                            index += 1 ;
                            if( index == str.m_size-1)
                                return true ;
                        }
                    }
                }
            }
            return false ;
        }
    }

    void printStr()
    {
        cout << m_PChars << endl;
    }
};


int main()
{
    MyStr s("hello world! ");
    cout << s.lenStr(s.m_PChars) << endl ;

    MyStr s1("It is me.");
    s.add(s1);
    s.printStr();

    MyStr s2("rld");
    cout << s.check_substr(s2) << endl ;
    return 0 ;
}