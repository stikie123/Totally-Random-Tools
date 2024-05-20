#include <cs50.h>
#include <ctype.h>
#include <math.h>
#include <stdio.h>
#include <string.h>

int compute_score(float S, float L);

int main(void)
{
    string text = get_string("Text: ");
    int wordCount = 1; // Start from 1 to account for the last word
    int sentenceCount = 0;
    float letters = 0;

    // Calculate number of words, letters, and sentences
    for (int i = 0, n = strlen(text); i < n; i++)
    {
        if (isalpha(text[i]))
        {
            letters++;
        }
        else if (text[i] == ' ')
        {
            wordCount++;
        }
        else if (text[i] == '.' || text[i] == '!' || text[i] == '?')
        {
            sentenceCount++;
        }
    }

    // Compute L and S
    float L = (letters / wordCount) * 100;
    float S = ((float)sentenceCount / wordCount) * 100;

    // Compute the Coleman-Liau index
    int grade = compute_score(S, L);

    // Output the result
    if (grade < 1)
    {
        printf("Before Grade 1\n");
    }
    else if (grade >= 16)
    {
        printf("Grade 16+\n");
    }
    else
    {
        printf("Grade %i\n", grade);
    }
}

int compute_score(float S, float L)
{
    return round(0.0588 * L - 0.296 * S - 15.8);
}
