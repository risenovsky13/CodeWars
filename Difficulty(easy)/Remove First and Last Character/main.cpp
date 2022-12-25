#include <string>

using namespace std; 

string sliceString (string str )
{
    int n = str.length();
    str.erase(0, 1); 
    str.erase(n-2, 1);
    
    return str;
}
