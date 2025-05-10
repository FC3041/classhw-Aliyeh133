#include<iostream>
#include<string>
#include<vector>
using namespace std;

int main()
{
    string name = "ali" ;
    string name2 = "zahra";
    // cout << name << " : " << name.size() << endl ;
    // name += " + " + name2 +  "\n" ;
    // cout << name << endl ;
    cout << name.append("+") << endl;
    cout << name.append(name2) << endl;
    vector<int> nums ;
    nums.push_back(5);
    nums.push_back(10);
    for(int i=0 ; i<nums.size() ; i++)
        cout << nums.at(i) << " " ;

    cout << '\n' ;
    
    nums.insert(nums.begin(),2);
    for(int i=0 ; i<nums.size() ; i++)
        cout << nums.at(i) << " ";

    cout << '\n' ;

    nums.erase(nums.begin());
    for(int i=0 ; i<nums.size() ; i++)
        cout << nums.at(i) << " ";
}