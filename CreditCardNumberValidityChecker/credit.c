#include <cs50.h>
#include <stdio.h>

int main(void)
{
    long long card_number;

    // Prompt user for credit card number
    do
    {
        card_number = get_long("Enter credit card number: ");
    }
    while (card_number <= 0);

    // Variables to store checksum and count of digits
    int checksum = 0;
    int count = 0;
    long long temp = card_number; // Store the original card number for later use

    // Iterate through the credit card number
    while (temp > 0)
    {
        // Extract the last digit
        int digit = temp % 10;
        // If it's an odd digit position (counting from the right), add it to checksum
        if (count % 2 == 0)
        {
            checksum += digit;
        }
        else
        {
            // If it's an even digit position, double it and add its digits to checksum
            int doubled = digit * 2;
            checksum += doubled % 10 + doubled / 10;
        }
        // Move to the next digit
        temp /= 10;
        count++;
    }

    // Check if the card is valid according to Luhn's algorithm
    if (checksum % 10 == 0)
    {
        // Determine the type of card based on its starting digits and number of digits
        // American Express starts with 34 or 37 and has 15 digits
        if (count == 15 &&
            (card_number / 10000000000000 == 34 || card_number / 10000000000000 == 37))
        {
            printf("AMEX\n");
        }
        // MasterCard starts with 51, 52, 53, 54, or 55 and has 16 digits
        else if (count == 16 &&
                 (card_number / 100000000000000 >= 51 && card_number / 100000000000000 <= 55))
        {
            printf("MASTERCARD\n");
        }
        // Visa starts with 4 and has 13 or 16 digits
        else if ((count == 13 && card_number / 1000000000000 == 4) ||
                 (count == 16 && card_number / 1000000000000000 == 4))
        {
            printf("VISA\n");
        }
        else
        {
            printf("INVALID\n");
        }
    }
    else
    {
        printf("INVALID\n");
    }

    return 0;
}
