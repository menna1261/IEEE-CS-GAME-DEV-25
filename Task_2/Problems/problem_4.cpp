#include <iostream>
using namespace std;

struct calcDistance {

    int x1;
    calcDistance(int X1):x1(X1){}
};

class CalcDistance {

    int x2;
    
public:
    CalcDistance(int x2) :x2(x2){}
  
    int getValue() {
        return x2;
    }
};


int main()
{
    calcDistance point1(10);
    CalcDistance point2(5);
   
    cout << "The Distance between the 2 points is : " << point1.x1 - point2.getValue() << endl;

}
