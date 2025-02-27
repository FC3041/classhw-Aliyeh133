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


    void resize_and_delete(int newsize,int index)
    {
        int* newlist = new int(sizeof(int)*newsize);
        for(int i=0 ; i<newsize ; i++ )
        {
            if(i < index)
                newlist[i] = m_pnums[i] ;
                
            if(i >= index)
                newlist[i] = m_pnums[i+1];
        }
        delete(m_pnums);
        m_size = newsize ;
        m_pnums = newlist ;    
    }


    void sort()
    {
        for(int i=0 ; i<m_size ; i++)
        {
            for(int j=i+1 ; j<m_size ; j++)
                if(m_pnums[i] > m_pnums[j])
                {
                    int temp = m_pnums[i] ;
                    m_pnums[i] = m_pnums[j];
                    m_pnums[j] = temp ;
                }
        }
    }

    void swap()
    {
        for(int i=0 ; i<m_size/2 ; i++)
        {
            int temp = m_pnums[i] ;
            m_pnums[i] = m_pnums[(m_size)-1-i];
            m_pnums[(m_size)-1-i] = temp ;
        }
    }


    void print_list()
    {
        for(int i=0 ; i<m_size ; i++)
            cout << m_pnums[i] << " " ;
    }


};

int main()
{
    int nums[6] = {1,2,3,4,5,6} ;
    MyList m(6,nums) ;
    m.resize_and_delete(5,0);
    cout << "delete :  " << "nums = {" ;
    m.print_list()  ;
    cout << "}" << endl ;


    int nums1[5] = {6,7,-1,67,76} ;
    MyList m1(5,nums1);
    m1.sort();
    cout << "sort :  " << "nums1 = {" ;
    m1.print_list()  ;
    cout << "}" << endl ;

    int nums2[7] = {1,2,3,4,5,6,7} ;
    MyList m2(7,nums2);
    m2.swap();
    cout << "swap : " << "nums2 = {" ;
    m2.print_list()  ;
    cout << "}" << endl ;    
}