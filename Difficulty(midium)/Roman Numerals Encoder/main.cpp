#include <iostream>
#include <string>

using namespace std;

string solution(int yrs)
{
    string str_romans[] = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
    string nRoman = "";
    int values[] = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};

    if (yrs > 3999)
        return nRoman;

    for (int i = 0; i < 13; ++i)
    {
        while (yrs - values[i] >= 0)
        {
            nRoman += str_romans[i];
            yrs -= values[i];
        }
    }

    return nRoman;              
}

int main()
{
    int r = 3999;
    string nRoman;

    nRoman = solution(r);
    cout << nRoman;

    return (0);
}

//  That(solution(182),  Equals("CLXXXII"));
//  That(solution(1990), Equals("MCMXC"));
//  That(solution(1875), Equals("MDCCCLXXV"));

// "I"  1
// "V"  5          "IV"        4
// "X"  10         "IX"        9
// "L"  50         "XL"        40
// "C"  100        "XC"        90
// "D"  500        "CD"        400
// "M"  1,000      "CM"        900