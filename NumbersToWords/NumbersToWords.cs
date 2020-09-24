using System;
using NToW.Models;

namespace NuWord
{
  public class NumbersToWords
  {
    public static void Main()
    {
      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine("Enter a number to convert it into a word! Or enter x to exit.");
        string userInput = Console.ReadLine();
        if (userInput != "x")
        {
          Console.WriteLine("The word form of this is " + Numbers.GetWord(userInput));
          i--;
        }
        else
        {
          break;
        }
      }
    }
  }
}
