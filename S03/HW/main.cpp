#include<iostream>
#include<string.h>
#include<stdlib.h>

using namespace std;

class Student
{
public:
    int m_stdNum;
    char m_FirstName[20];
    char m_LastName[20];
    int m_CoursesPassed;
    int m_Credits[40];
    double m_Grades[40];
    char* m_CourseNames[40];

    Student(int stdnum, const char* fname, const char* lname,int numofcourse)
    {
        m_stdNum = stdnum ;
        m_FirstName[20] = *fname ;
        m_LastName[20] = *lname ;
        m_CoursesPassed = numofcourse ;
    }

    ~Student()
    {
        cout << "Distruct" << endl ;
    }

    double GetGPA()
    {
        double sumGrade = 0;
        int sumCredit = 0;
        for(int i=0; i<m_CoursesPassed; i++) {
            sumGrade += m_Credits[i] * m_Grades[i];
            sumCredit += m_Credits[i];
        }
        return sumGrade / sumCredit;
    }

    void list_courses()
    {
        for(int k=0; k<m_CoursesPassed; k++) {
            cout << m_CourseNames[k] << ": "
                      << m_Credits[k] << " : "
                      << m_Grades[k] << endl;        
        }
    }

    void register_course(int credits, const char* name, double grade)
    {
        m_Credits[m_CoursesPassed] = credits;
        m_Grades[m_CoursesPassed] = grade;
        char* namecopy = new char[strlen(name) + 1];
        strcpy(namecopy, name);
        m_CourseNames[m_CoursesPassed] = namecopy;
    }
};


int main()
{
    int stdnum ;
    cin >> stdnum ;

    char fname[20];
    cin >> fname ;

    char lname[20];
    cin >> lname ;

    int nums ;
    cin >> nums ;

    Student s(stdnum,fname,lname,nums);

    s.m_CoursesPassed = 0 ;
    char bufc[20];
    double grade;
    int credits;

    while(nums>0)
    {
        cout << "course name? " ;
        cin >> bufc ;

        cout << "course credits? " ;
        cin >> credits ;

        cout << "course grade? " ;
        cin >> grade ;
        s.register_course(credits, bufc, grade);
        nums-- ;
        (s.m_CoursesPassed)++ ;
    }
    cout << stdnum << "   " << fname << " " << lname << endl ;
    s.list_courses();
    cout << "Average : " << s.GetGPA() << endl << endl ;
}