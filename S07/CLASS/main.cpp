#include<vector>
#include<iostream>
#include<string>
#include<stdio.h>
#include<Windows.h>

using namespace std;

class Myvector
{
    private:
        int m_capacity;
        int* m_buffer;
        int m_size;

    public:

    Myvector(int capacity=10):m_capacity(capacity),m_buffer(new int[capacity]),m_size(0){}

    ~Myvector()
    {
        delete [] this -> m_buffer ;
        this -> m_capacity = 0 ;
    }

    void add(int e)
    {
        m_buffer[m_size] = e ;
        m_size ++ ;
    }

    int at(int idx)
    {
        return m_buffer[idx] ;
    }
};


int main2()
{
    Myvector v;
    v.add(2);
    v.add(5);
    cout << v.at(0) << " " << v.at(1) << endl ;
    return 0 ;
}


class Keeptime
{

};


class Myfile
{
    string m_filename;
    FILE* m_fileHandle;

    public:
        Myfile(const string& filename)
        :m_filename(filename)
        {
            m_fileHandle = fopen(m_filename.c_str(),"r");
        }

        ~Myfile()
        {
            fclose(m_fileHandle);
        }

        void writelen(const string& str)
        {
            fprintf(m_fileHandle,str.c_str());
        }
};

int main3()
{
    unsigned long long l = GetTickCount64();
    cout << l << endl;
    l = GetTickCount64();
    cout << l << endl;
    // Myfile f("test.txt");
    // f.writelen("test \n");
    return 0 ;
}

int main()
{

}