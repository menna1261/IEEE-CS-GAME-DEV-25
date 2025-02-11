#include <iostream>
using namespace std;

class Employee {

private:
	int id;
	string name;
	double salary;

public:
	Employee(int id , string name , double salary): id(id),name(name),salary(salary){}

	void raiseSalary(double amount) {
		salary *= amount;
	}

	double getSalary() {
		return salary;
	}


};



int main()
{
	Employee employee(123, "Menna", 50000);
	employee.raiseSalary(1.2);
	cout << employee.getSalary();

}