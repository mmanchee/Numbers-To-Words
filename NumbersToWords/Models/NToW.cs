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
      { 3, "Hundred" }, { 4, "Thousand" }, { 6, "Hundred" }, { 7, "Million" }, { 9, "Hundred" }, { 10, "Billion" }, { 12, "Hundred" }, { 13, "Trillion" }
      };

      string word = "";
      string formalWord = "";
      int a = 0;
      for (int i = userInput.Length; i > 0; i--)
      {
        string character = userInput[a].ToString();
        int user = int.Parse(character);
        if ( user == 0 )
        {
          if (i == 1 && userInput.Length == 1)
          {
            formalWord = "Zero";
          }
        }
        else if (i == 1 || i == 3 || i == 4 || i == 6 || i == 7 || i == 9 || i == 10 || i == 12 || i == 13)
        {
          foreach (KeyValuePair<int, string> set in singlesPlace)
          {
            if (set.Key == user)
            {
              formalWord += set.Value;
            }
          }
        }
        else if ( i == 2 || i == 5 || i == 8 || i == 11)
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
            if (set.Key == user)
            {
              formalWord += set.Value;
            }
          }
        }
        a++;
        if (formalWord.Length > 5)
        {
          word = formalWord.Substring(formalWord.Length - 5, 5);
        }
        int c = 0;
        if (word.Contains("sand"))
        {

        }
        else if ((word.Contains("ered"))
        {
        c = 1
        }
        else if (word.Contains("ion"))
        {
        c = 1
        }
        
        if (user != 0)
        {
        foreach (KeyValuePair<int, string> set in bigPlaces)
          {
            if (set.Key == i)
            {
              formalWord += set.Value;
            }
          }
        }
        else if ( i != 3 || !) 
        {
        foreach (KeyValuePair<int, string> set in bigPlaces)
          {
            if (set.Key == i)
            {
              formalWord += set.Value;
            }
          }
        }
        
      }
      return formalWord;
    }
  }
}