//*********
//  DONE!
//*********
#include <string>
using namespace std ; 

string reverseString (string str )
{
    string txt = str;
    reverse(txt.begin(),txt.end());
   
    return txt;
}
