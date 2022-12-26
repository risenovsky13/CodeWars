#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

string solution(int yrs)
{
  //       1        5         10        50         100      500      1000
  //       |        |          |         |          |        |          |
  string I = "I", V = "V", X = "X", L = "L", C = "C", D = "D", M = "M";
  string nRoman = " ";
  int n;

  if (yrs >= 1000)
  {
    n = (yrs % 1000);
  }

  cout << n << " ";

  return nRoman;
}

int main()
{
  int r = 1875; //,1990 , 182 ;
  string nRoman;
  nRoman = solution(r);
  // cout << r << " .";
  // cout << nRoman;
  return (0);
}