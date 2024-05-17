using System;

class Credit
{
  static void Main()
  {
    long cardNumber;

    // Prompt user for credit card number
    do
    {
      Console.Write("Enter credit card number: ");
    }
    while (!long.TryParse(Console.ReadLine(), out cardNumber) || cardNumber <= 0);

    // Variables to store checksum and count of digits
    int checksum = 0;
    int count = 0;
    long temp = cardNumber; // Store the original card number for later use

    // Iterate through the credit card number
    while (temp > 0)
    {
      // Extract the last digit
      int digit = (int)(temp % 10);
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
          (cardNumber / 10000000000000 == 34 || cardNumber / 10000000000000 == 37))
      {
        Console.WriteLine("AMEX");
      }
      // MasterCard starts with 51, 52, 53, 54, or 55 and has 16 digits
      else if (count == 16 &&
               (cardNumber / 100000000000000 >= 51 && cardNumber / 100000000000000 <= 55))
      {
        Console.WriteLine("MASTERCARD");
      }
      // Visa starts with 4 and has 13 or 16 digits
      else if ((count == 13 && cardNumber / 1000000000000 == 4) ||
               (count == 16 && cardNumber / 1000000000000000 == 4))
      {
        Console.WriteLine("VISA");
      }
      else
      {
        Console.WriteLine("INVALID");
      }
    }
    else
    {
      Console.WriteLine("INVALID");
    }
  }
}