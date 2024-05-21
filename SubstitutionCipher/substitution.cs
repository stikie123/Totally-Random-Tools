using System;

class Substitution
{
    // Main function
    static void Main(string[] args)
    {
        // Check for single command-line argument
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: dotnet run <key>");
            Environment.Exit(1);
        }

        string key = args[0];

        // Validate the key
        if (!IsValidKey(key))
        {
            Console.WriteLine("Key must contain 26 unique alphabetic characters.");
            Environment.Exit(1);
        }

        // Prompt user for plaintext
        Console.Write("plaintext: ");
        string plaintext = Console.ReadLine();

        // Encrypt the plaintext
        string ciphertext = Encrypt(plaintext, key);

        // Output the ciphertext
        Console.WriteLine("ciphertext: " + ciphertext);
    }

    // Function to check if the key is valid
    static bool IsValidKey(string key)
    {
        if (key.Length != 26)
        {
            return false;
        }

        bool[] seen = new bool[26];

        for (int i = 0; i < key.Length; i++)
        {
            if (!char.IsLetter(key[i]))
            {
                return false;
            }

            int index = char.ToLower(key[i]) - 'a';
            if (seen[index])
            {
                return false;
            }
            seen[index] = true;
        }

        return true;
    }

    // Function to encrypt plaintext using the substitution key
    static string Encrypt(string plaintext, string key)
    {
        char[] ciphertext = new char[plaintext.Length];

        for (int i = 0; i < plaintext.Length; i++)
        {
            if (char.IsLetter(plaintext[i]))
            {
                if (char.IsLower(plaintext[i]))
                {
                    ciphertext[i] = char.ToLower(key[plaintext[i] - 'a']);
                }
                else
                {
                    ciphertext[i] = char.ToUpper(key[plaintext[i] - 'A']);
                }
            }
            else
            {
                // Non-alphabetic characters remain unchanged
                ciphertext[i] = plaintext[i];
            }
        }

        return new string(ciphertext);
    }
}
