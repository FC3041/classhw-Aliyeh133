#include<iostream>
#include<string.h>
#include<stdlib.h>

class Student
{
    public :
        int m_stdNum;
        char m_FirstName[20];
        char m_LastName[20];
        int m_CoursesPasssed;
        int m_Credits[40];
        double m_Grades[40];
        char* m_CourseName[40];

    double GetGPA()
    {
        int sumGrades = 0 ;
        int sumCredits = 0 ;
        for(int i=0 ; i<m_CoursesPasssed ; i++)
        {
            sumGrades += m_Grades[i] * m_Credits[i];
            sumCredits += m_Credits[i] ;
        }
        return sumGrades/sumCredits ;
    }

    void register_course(int credits, const char* name, double grade)
    {
        m_Credits[m_CoursesPasssed] = credits;
        m_Grades[m_CoursesPasssed] = grade;
        char* namecopy = new char[strlen(name) + 1];
            //(char*) malloc(strlen(name) + 1);
        strcpy(namecopy, name);
        m_CourseName[m_CoursesPasssed] = namecopy;
        m_CoursesPasssed++;       
    }

    void list_courses()
    {
        for(int j=0 ; j<m_CoursesPasssed ; j++)
            std::cout << m_CourseName[j] << " : " << m_Credits[j] << " : " << m_Grades[j] << std::endl ;
    }
};


int main()
{
    Student s ;
    s.m_CoursesPasssed = 0;
    char bufc[20];
    double grade;
    int credits;
    while(true)
    {
        std::cout << "course name?" ;
        std::cin >> bufc ;
        if (*bufc == 'A')
            break;
        std::cout << "course credits?" ;
        std::cin >> credits ;
        std::cout << "course grade?" ;
        std::cin >> grade ;
        s.register_course(credits, bufc, grade);
    }
    s.list_courses();
    std::cout << s.GetGPA() << std::endl;
}