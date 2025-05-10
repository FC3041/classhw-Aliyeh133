#include<iostream>
#include<stdlib.h>

using namespace std;

class MyList
{
    public:
        int m_size;
        int m_capacity;
        int* m_pNums;

        MyList():m_size(0),m_capacity(0),m_pNums(nullptr){};

        MyList(int size, int capacity , const int* nums)
        :m_size(size), m_capacity(capacity)
        {
            m_pNums = (int *)malloc(sizeof(int)*capacity);
            for (int i=0; i<m_size;i++)
            {
                m_pNums[i] = nums[i];
            }
        }

        void print_list()
        {
            cout << "size:" << m_size << " capacity:" << m_capacity << endl;
            for(int i=0;i<m_size;i++)
            {
                cout << m_pNums[i] << ",";
            }
            cout << endl;

        }

        int len(){return m_size;}

        void append(int value)
        {
            if (m_size == m_capacity)
            {
                if (m_size ==0){resize(1);}
                else
                {
                    resize(m_capacity*2);
                }
            }
            m_pNums[m_size] = value;
            m_size ++;
        }

        void insert(int index, int value)
        {
            if (m_size==m_capacity)
            {
                if (m_size==0){resize(1);}
                else{resize(m_capacity*2);}
            }
            for(int i=m_size; i>=index ;i--)
            {
                m_pNums[i] = m_pNums[i-1]; 
            }
            m_pNums[index] = value;
            m_size++;
        }

        void clear()
        {
            m_size = 0;
            resize(1);
        }

        void erase(int index)
        {
            for(int i=index;i<m_size-1;i++)
            {
                m_pNums[i] = m_pNums[i+1];
            }

            m_size --;
        }

        void reverse()
        {
            for(int i=0;i<int(m_size/2);i++)
            {
                int temp = m_pNums[i];
                m_pNums[i] = m_pNums[m_size-1-i];
                m_pNums[m_size-i-1] = temp;
            }
        }

        int at(int index)
        {
            if((index < m_size) && (index>-1))
                return m_pNums[index];
            throw out_of_range("Out of range");
        }

        void sort()
        {
            for(int i=0 ; i<m_size ; i++)
            {
                for(int j=i+1 ; j<m_size ; j++)
                {
                    if( m_pNums[i] > m_pNums[j])
                    {
                        int temp = m_pNums[i] ;
                        m_pNums[i] = m_pNums[j] ;
                        m_pNums[j] = temp ;
                    }
                }
            }
        }


    private:
        void resize(int newsize)
        {
            int* newNums = (int*)malloc(sizeof(int)*(newsize));
            for(int i=0; i<m_size;i++)
            {
                newNums[i] = m_pNums[i];
            }
            free(m_pNums);
            m_pNums = newNums;
            m_capacity = newsize;

        }
};

int main()
{
    MyList l1;

    int nums[6] = {6,9,0,2,5,6};
    MyList l(6, 10, nums);
    l.sort();
    l.print_list();
    return 0;
}