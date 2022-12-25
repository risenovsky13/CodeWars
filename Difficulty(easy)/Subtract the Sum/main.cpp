//*****************
//      DONE!
//*****************
#include <string>

using namespace std;

string SubtractSum(int n)
{
    int sum;     
    while (n<10000 && n>=10) 
    {        
        sum = (n%10) + ((n/10)%10) + ((n/100)%10) + ((n/1000)%10);
        n -= sum;
        if(n<=100) 
        {
            int nFruit = 9; 
            int tab[11];             
            
            for(int i=0 ; i<11; i++) 
            tab[i] = nFruit;     nFruit + 9; 
              
            for(int i=10 ; i>=0; i--) 
            if(n == tab[i])  return "apple";
        }        
    }

    return "null";
}
