#include<iostream>
using namespace std;

class MyList
{
    public:
        int m_size ;
        int* m_pnums ;

    MyList(int s , int* nums)
    :m_size(s)
    {
        m_pnums = new int[sizeof(int)*s] ;
        int i ;
        for(i=0 ; i<m_size ; i++)
            m_pnums[i] = nums[i] ;     
    }

    void resize(int newsize)
    {
        int* newMem = new int(sizeof(int)*newsize);
        int i ;
        for(i=0 ; i<m_size ; i++)
        newMem[i] = m_pnums[i]  ;
        delete(m_pnums);
        m_size = newsize ;
        m_pnums = newMem ;
        // newMem = NULL ;
    }

    void append(int x)
    {
        resize(m_size+1);
        m_pnums[m_size-1] = x ;
    }

    void print_list()
    {
        for(int i=0 ; i<m_size ; i++)
            cout << m_pnums[i] << " " ;
    }
};

int main()
{
    int nums[5] = {1,2,3,4,5} ;
    MyList m(5,nums);
    m.append(14);
    m.print_list();
}