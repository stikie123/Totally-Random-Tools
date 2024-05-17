# Credit Card Validator
This program is a simple credit card number validator implemented in C#. It verifies the validity of a credit card number using the Luhn algorithm and identifies the type of card (American Express, MasterCard, Visa, or Invalid).

## How to Use
Clone Repository: Clone this repository to your local machine using git clone.

Compile Code: Compile the C# code using a C# compiler such as Visual Studio or Mono.

Run the Program: Execute the compiled program. It will prompt you to enter a credit card number. Follow the prompts and enter the credit card number you want to validate.

View Result: After entering the credit card number, the program will output whether the card is valid or invalid, and if valid, it will identify the type of card.

## Features
Validates credit card numbers using the Luhn algorithm.
Identifies the type of credit card (American Express, MasterCard, Visa) based on the card number.
Simple command-line interface for user interaction.
Code Explanation
Main(): The entry point of the program. It prompts the user to enter a credit card number, validates it, and identifies its type.
Luhn Algorithm: The algorithm used to validate the credit card number. It iterates through the digits of the card number and performs checksum calculations.
Card Type Identification: Determines the type of card (American Express, MasterCard, Visa) based on the starting digits and length of the card number.
Input Validation: Ensures that the user enters a valid credit card number (a positive integer).
### Dependencies
None
### Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or create a pull request.
