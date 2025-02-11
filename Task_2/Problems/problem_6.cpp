#include <iostream>
using namespace std;

static int counter = 0;
static int CountCalls() {
	
	counter++;
	return counter;
}

int main()
{
	cout << CountCalls() << endl;
	cout << CountCalls() << endl;
	cout << CountCalls() << endl;
	cout << CountCalls() << endl;

}
