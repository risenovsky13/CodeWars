#include <iostream>
#include <utility>

using namespace std;

int SecondsToHours(int Hours,int Minutes, int Seconds)
{
    if(Seconds>359999) return 0;

    Hours = (Seconds/60)/60; 
    Minutes = (Seconds - ((Hours*60)*60))/60; 
    Seconds -= ((Hours*60)*60)+(Minutes*60);
    
    return Hours,Minutes,Seconds;
}

int main()
{
    int secUser = 359999; 
    int Hours=0, Minutes=0, Seconds=0;
     
    Hours   =  SecondsToHours(Hours,Minutes,secUser);
    Minutes =  SecondsToHours(Hours,Minutes,secUser);
    Seconds =  SecondsToHours(Hours,Minutes,secUser);

    if(SecondsToHours == 0) 
            cout << "ERROR: Too high value!";

    cout << Hours << ":" << Minutes << ":" << Seconds << endl;
    cout << secUser << endl;

    return 0;
}

    //  The maximum time never exceeds 359999 (99:59:59)   HH:MM:SS