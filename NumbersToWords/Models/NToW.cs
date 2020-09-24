using System.Collections.Generic;

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
      { 3, "Hundred" }, { 4, "Thousand" }, { 7, "Million" }, { 10, "Billion" }, { 13, "Trillion" }
      };

      string formalWord = "Null";
      // int size = userInput.Length;

      // for (int i = size; i < 1; i--)
      // {
      //   if (i == 1)
      //   {
      //     int user = int.Parse(userInput[i]);
      //     foreach (KeyValuePair<int, string> set in singlesPlace)
      //     {
      //       if (set.Key == user)
      //       {
      //         formalWord = set.Value;
      //       }
      //     }
      //   }
      // }
      return formalWord;
    }
  }
}