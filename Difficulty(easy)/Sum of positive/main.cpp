//****************
//      DONE!
//****************
#include <vector>

using namespace std;

int positive_sum (const vector<int> arr)
{
    int n = size(arr);
    int sum=0;
    for(int i=0; i<n; i++) 
    {
        if(arr[i]>=0) sum += arr[i];
        else sum += 0;
    }
    
    return sum;
}