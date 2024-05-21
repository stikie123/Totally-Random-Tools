#include <cs50.h>
#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Function prototypes
bool is_valid_key(string key);
string encrypt(string plaintext, string key);

int main(int argc, string argv[])
{
    // Check for single command-line argument
    if (argc != 2)
    {
        printf("Usage: ./substitution key\n");
        return 1;
    }

    string key = argv[1];

    // Validate the key
    if (!is_valid_key(key))
    {
        printf("Key must contain 26 unique alphabetic characters.\n");
        return 1;
    }

    // Prompt user for plaintext
    string plaintext = get_string("plaintext: ");

    // Encrypt the plaintext
    string ciphertext = encrypt(plaintext, key);

    // Output the ciphertext
    printf("ciphertext: %s\n", ciphertext);

    // Free the allocated memory for ciphertext
    free(ciphertext);

    return 0;
}

// Function to check if the key is valid
bool is_valid_key(string key)
{
    int length = strlen(key);

    // Key must be exactly 26 characters long
    if (length != 26)
    {
        return false;
    }

    bool seen[26] = {false};

    for (int i = 0; i < length; i++)
    {
        if (!isalpha(key[i]))
        {
            return false;
        }

        // Check for duplicate letters (case insensitive)
        int index = tolower(key[i]) - 'a';
        if (seen[index])
        {
            return false;
        }
        seen[index] = true;
    }

    return true;
}

// Function to encrypt plaintext using the substitution key
string encrypt(string plaintext, string key)
{
    int length = strlen(plaintext);
    string ciphertext = malloc(length + 1); // Allocate memory for ciphertext

    for (int i = 0; i < length; i++)
    {
        if (isalpha(plaintext[i]))
        {
            // Preserve case and substitute letters
            if (islower(plaintext[i]))
            {
                ciphertext[i] = tolower(key[plaintext[i] - 'a']);
            }
            else
            {
                ciphertext[i] = toupper(key[plaintext[i] - 'A']);
            }
        }
        else
        {
            // Non-alphabetic characters remain unchanged
            ciphertext[i] = plaintext[i];
        }
    }

    ciphertext[length] = '\0'; // Null
    return ciphertext;
}
