#include <iostream>
using namespace std;

class BankAccount {

private:
	double balance;
	string accountNumber;

public:

	BankAccount(string accountNumber, double balance) : accountNumber(accountNumber),balance(balance){}

	void deposit(double amount) {
		balance += amount;
	}

	void withDraw(double amount) {
		if (balance < amount) {
			cout << "Invalid transaction" << endl;
		}
		else {
			balance -= amount;
		}
	}

	double getBalance() {
		return balance;
	}
};


int main()
{

	BankAccount account("12345678", 1000);
	account.deposit(500);
	account.withDraw(200);
	cout << "Balance: " << account.getBalance() << endl;
	
}
