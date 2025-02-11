#include <iostream>
using namespace std;

string append(string& S) {
	S += " World!";
	return S;
}


int main()
{
	string S = "Hello";
	cout << append(S) << endl;
}