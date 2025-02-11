#include <iostream>
using namespace std;

enum Suit { Hearts, Diamonds, Clubs, Spades };

class Card {
private:
    Suit suit;
    int value;

public:
    Card(Suit cardSuit, int cardValue): suit(cardSuit), value(cardValue) {}

    void displayCard() const {
        string suitStr;
        switch (suit) {
        case Hearts: suitStr = "Hearts"; 
            break;
        case Diamonds: suitStr = "Diamonds"; 
            break;
        case Clubs: suitStr = "Clubs";
            break;
        case Spades: suitStr = "Spades"; 
            break;
        }
        cout << "Card: " << value << " of " << suitStr << std::endl;
    }
};

int main() {
    Card card(Hearts, 10);
    card.displayCard(); 
    return 0;
}
