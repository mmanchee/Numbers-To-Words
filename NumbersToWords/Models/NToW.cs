using System.Collections.Generic;
using System;

namespace NToW.Models
{
  public class Numbers
  {
    public static string GetWord(string userInput)
    {
      Dictionary<int, string> singlesPlace = new Dictionary<int, string>(){
      { 1, "One"}, { 2, "Two" }, { 3, "Three" }, { 4, "Four" }, { 5, "Five" },
      { 6, "Six" }, { 7, "Seven" }, { 8, "Eight" }, { 9, "Nine" }
      };
      Dictionary<int, string> doublesPlace = new Dictionary<int, string>(){
      { 2, "Twenty" }, { 3, "Thirty" }, { 4, "Fourty" }, { 5, "Fifty" },
      { 6, "Sixty" }, { 7, "Seventy" }, { 8, "Eighty" }, { 9, "Ninety" },
      { 10, "Ten" }, { 11, "Eleven" }, { 12, "Twelve" }, { 13, "Thirteen" },
      { 14, "Fourteen" }, { 15, "Fifteen"}, { 16, "Sixteen" }, { 17, "Seventeen" },
      { 18, "Eighteen" }, { 19, "Nineteen" }
      };
      Dictionary<int, string> bigPlaces = new Dictionary<int, string>(){
      { 2, "Hundred" }, { 3, "Thousand" }, { 6, "Million" }, { 9, "Billion" }, { 12, "Trillion" }
      };

      string formalWord = "n";
      int a = 0;
      for (int i = userInput.Length; i > 0; i--)
      {
        string character = userInput[a].ToString();
        int user = int.Parse(character);
        if (i == 1)
        {
          Console.WriteLine("in ones");
          foreach (KeyValuePair<int, string> set in singlesPlace)
          {
            if (set.Key == user)
            {
              formalWord = set.Value;
            }
          }
        }
        if ( i == 2 )
        {
          if ( user == 1 )
          {
            string numString = userInput[(a+1)].ToString();
            int num1 = int.Parse(numString);
            user = 10 + num1;
            i--;
            a++;
          }  
          foreach (KeyValuePair<int, string> set in doublesPlace)
          {
            formalWord = set.Value;
          }
        }
      a++;
      }
    return formalWord;
    }
  }
}