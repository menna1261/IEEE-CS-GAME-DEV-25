#include <iostream>

struct Logger {
    static void log(const std::string& message) {
        std::cout << message << std::endl;
    }
};

int main() {
    Logger::log("This is a log message.");
}