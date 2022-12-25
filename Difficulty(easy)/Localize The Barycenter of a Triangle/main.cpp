//*****************
//      DONE!
//*****************
#include <utility>
#include <math.h>

using namespace std;

using point = const pair<double, double>;

pair<double, double> barTriang(point p1, point p2, point p3)
{    
    using point = pair<double, double>;
    point xy;

    xy.first  = round (((p1.first + p2.first + p3.first)    / 3) * 10000) / 10000 ;
    xy.second = round (((p1.second + p2.second + p3.second) / 3) * 10000) / 10000 ;

    return xy;
}
