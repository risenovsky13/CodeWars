// DONE !

#include <cmath>
using namespace std;

bool approx_equals(double a, double b) 
{
  double aprox_comp;
  bool result;
  
  a<b ? aprox_comp = b-a : aprox_comp = a-b ;
  
  if(aprox_comp>0.001 || aprox_comp < -0.001) result = false;
  if(aprox_comp<=0.001 && aprox_comp>=-0.001) result = true;
  
  return result;
}
