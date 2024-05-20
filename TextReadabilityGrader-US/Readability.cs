using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioExcelGame.TextReadabilityGrader_US
{
  internal class Readability
  {
    static void TextReadability(string[] args)
    {
      Console.Write("Text: ");
      string text = Console.ReadLine();

      int wordCount = 1; // Start from 1 to account for the last word
      int sentenceCount = 0;
      float letters = 0;

      // Calculate number of words, letters, and sentences
      foreach (char c in text)
      {
        if (char.IsLetter(c))
        {
          letters++;
        }
        else if (c == ' ')
        {
          wordCount++;
        }
        else if (c == '.' || c == '!' || c == '?')
        {
          sentenceCount++;
        }
      }

      // Compute L and S
      float L = (letters / wordCount) * 100;
      float S = ((float)sentenceCount / wordCount) * 100;

      // Compute the Coleman-Liau index
      int grade = ComputeScore(S, L);

      // Output the result
      if (grade < 1)
      {
        Console.WriteLine("Before Grade 1");
      }
      else if (grade >= 16)
      {
        Console.WriteLine("Grade 16+");
      }
      else
      {
        Console.WriteLine($"Grade {grade}");
      }
    }

    static int ComputeScore(float S, float L)
    {
      return (int)Math.Round(0.0588 * L - 0.296 * S - 15.8);
    }
  }

}
