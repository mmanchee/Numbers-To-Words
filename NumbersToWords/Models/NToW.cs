using System.Collections.Generic;
using System;

namespace NToW.Models
{
  public class Numbers
  {
    public string WordString { get; set; }
    public string NumberString { get; set; }
    Dictionary<int, string> singlesPlace = new Dictionary<int, string>(){
    { 1, "One "}, { 2, "Two " }, { 3, "Three " }, { 4, "Four " }, { 5, "Five " },
    { 6, "Six " }, { 7, "Seven " }, { 8, "Eight " }, { 9, "Nine " }, { 10, "Ten " }, 
    { 11, "Eleven " }, { 12, "Twelve " }, { 13, "Thirteen " }, { 14, "Fourteen " }, 
    { 15, "Fifteen "}, { 16, "Sixteen " }, { 17, "Seventeen " },{ 18, "Eighteen " }, { 19, "Nineteen " }
    };
    Dictionary<int, string> doublesPlace = new Dictionary<int, string>(){
    { 2, "Twenty" }, { 3, "Thirty" }, { 4, "Forty" }, { 5, "Fifty" },
    { 6, "Sixty" }, { 7, "Seventy" }, { 8, "Eighty" }, { 9, "Ninety" }
    
    };
    Dictionary<int, string> bigPlaces = new Dictionary<int, string>(){
    { 1, "Thousand " },  { 2, "Million " },  { 3, "Billion " },  { 4, "Trillion " },
    { 5, "Quadrillion" }, { 6, "Quintillion" }, { 7, "Sextillion" }, { 8,"Septillion" }
    };
    public string TwoDigit(int num)
    {
      string word = "";  
      int some = 0;
      if ( num < 1 )
      {
        word = "";
      }
      else if ( num < 20 ) // everything from 1 - 19
      {
        word = this.singlesPlace[num];
      }
      else                // everything from 20 - 99
      {
        some = num / 10;
        word = this.doublesPlace[some];
        some = num % 10;
        if (some > 0)
        {
          word += "-" + this.singlesPlace[some];
        }
        
      }
    return word;
    }
    public string ThreeDigit(int num)
    {
      string word = "";  
      int some = 0;
      
      if ( num < 100 )
      {
        word = TwoDigit(num);
      }
      else if ( num < 1000)
      {
        some = num / 100;
        word += this.singlesPlace[some];
        word += "Hundred ";
        some = num % 100;
        word += word = TwoDigit(some);
      }
      return word;
    }
    public string GetWord(string userInput)
    {
      string formalWord = "";
      int a = 0;
      int user = int.Parse(userInput);
      if ( user == 0 )
      {
        formalWord = "Zero";
      }
      else
      {
        for (int i = 0; a < userInput.Length; i++)
        {
          int some = user % 1000;
          if (some > 0 && i > 0)
          {
            formalWord = this.bigPlaces[i] + formalWord;
          }
          formalWord = ThreeDigit(some) + formalWord + " ";
          user /= 1000;
          a += 3;
        }
      }
      return formalWord;
    }
  }
}