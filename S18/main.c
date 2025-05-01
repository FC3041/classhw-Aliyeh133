#include<stdio.h>

typedef int (* _two_number)(int a , int b) ;

int add(int x , int y){return x+y ;}
int multi(int x , int y){return x*y ;}
int sub(int x , int y){return x-y ;}
int divide(int x , int y){return x/y ;}

void apply(int* nums1, int* nums2, int* result, int len, _two_number fn)
{
    for(int i=0; i<len; i++)
    {
        result[i] = fn(nums1[i], nums2[i]);
    }
}

int main()
{
    int nums0[3] = {1,5,8};
    int nums1[3] = {5,10,9};
    int nums2[3];

    apply(nums0,nums1,nums2,3,add);

    for(int i=0 ; i<3 ; i++)
        printf("%d " , nums2[i]);
}