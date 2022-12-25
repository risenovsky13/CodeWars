//******************************
//    DONE!
//******************************        

#include <vector>
#include <algorithm>

using namespace std;

vector<int> flip(const char dir, const vector<int> & tab) 
{
    vector <int> arr = tab;
    if( dir == 'R' )  sort( arr.begin(), arr.end() );
    if( dir == 'L' )  sort( arr.begin(), arr.end(), greater() );
   
    return arr;
} 
