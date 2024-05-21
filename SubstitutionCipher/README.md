
# Substitution Cipher Program
This project implements a substitution cipher program in both C and C#. The substitution cipher encrypts messages by replacing each letter in the plaintext with a corresponding letter in the key, while preserving the case of the original letters.
## Program Details
### Validating the Key:

The key must be exactly 26 characters long.
The key must contain only alphabetic characters.
Each letter in the key must be unique (case-insensitive).  
Encrypting the Plaintext:

The program preserves the case of the original letters.  
Non-alphabetic characters in the plaintext are left unchanged.  
### Example Usage
For both versions, if the substitution key is QWERTYUIOPASDFGHJKLZXCVBNM, and the plaintext is Hello, World!, the output would be:

```makefile
plaintext: Hello, World!
ciphertext: Itssg, Vgksr!
```
## C Version
#### Prerequisites
- CS50 Library for C
- A C compiler (e.g., clang or gcc)
#### Files
- substitution.c: The main C program file.
### Compilation and Execution
### 1.  Compile the Program:
Make sure you have the CS50 library installed. Then, compile the program using the following command:

```bash
clang -o substitution substitution.c -lcs50
`````
Run the Program:  
Run the compiled executable with the substitution key as an argument:

```bash
./substitution <key>
```
Replace <key> with your 26-character substitution key. The program will prompt you to enter plaintext and then output the corresponding ciphertext.

## C# Version
#### Prerequisites
- .NET SDK
#### Files
- Substitution.cs: The main C# program file.
### Compilation and Execution
- Create a New .NET Console Application:
- Create a new .NET console application if you haven't already:

```bash
dotnet new console -n SubstitutionCipher
cd SubstitutionCipher
```
Replace the Contents of Program.cs:  
Copy and paste the C# code into the Program.cs file.

Run the Program:  
Run the program using the following command:

```sh
dotnet run <key>
```
Replace <key> with your 26-character substitution key. The program will prompt you to enter plaintext and then output the corresponding ciphertext.

