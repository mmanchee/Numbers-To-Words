using System.Collections.Generic;
using System;

namespace NToW.Models
{
  public class Numbers
  {
    public string NtWs { get; set; }
    Dictionary<int, string> singlesPlace = new Dictionary<int, string>(){
    { 1, "One"}, { 2, "Two" }, { 3, "Three" }, { 4, "Four" }, { 5, "Five" },
    { 6, "Six" }, { 7, "Seven" }, { 8, "Eight" }, { 9, "Nine" }, { 10, "Ten" }, 
    { 11, "Eleven" }, { 12, "Twelve" }, { 13, "Thirteen" }, { 14, "Fourteen" }, 
    { 15, "Fifteen"}, { 16, "Sixteen" }, { 17, "Seventeen" },{ 18, "Eighteen" }, { 19, "Nineteen" }
    };
    Dictionary<int, string> doublesPlace = new Dictionary<int, string>(){
    { 2, "Twenty" }, { 3, "Thirty" }, { 4, "Forty" }, { 5, "Fifty" },
    { 6, "Sixty" }, { 7, "Seventy" }, { 8, "Eighty" }, { 9, "Ninety" }
    
    };
    Dictionary<int, string> bigPlaces = new Dictionary<int, string>(){
    { 1, "Thousand" },  { 2, "Million" },  { 3, "Billion" },  { 4, "Trillion" }
    };
    public string ThreeDigit(int num)
    {
      string word = "";  
      int some = 0;
      if ( num < 1 )
      {
        word = "";
      }
      else if ( num < 20 ) // everything from 1 - 19
      {
        word = singlesPlace[num];
      }
      else if ( num < 100 ) // everything from 20 - 99
      {
        some = num / 10;
        word = doublesPlace[some];
        some = num % 10;
        word += singlesPlace[some];
      }
      else if ( num < 1000)
      {
        some = num / 100;
        word += singlesPlace[some];
        word += "Hundred";
        some = num % 100;

        if ( some < 20 ) // everything from 1 - 19
        {
          word += singlesPlace[num];
        }
        else if ( some < 100 ) // everything from 20 - 99
        {
          int selse = 0;
          selse = some / 10;
          word = doublesPlace[some];
          selse = some % 10;
          word += singlesPlace[some];
        }
      }
      return word;
    }
    public static string GetWord(string userInput)
    {
      string word = "";
      string formalWord = "";
      int a = 0;
      int user = int.Parse(userInput);
      if ( user == 0 )
      {
        formalWord = "Zero";
      }
      else
      {
        for (int i = 0; a < userInput.Length; i++) // 151,000,001
        {
          int some = user % 1000;    //--1   --0  151
          formalWord += ThreeDigit(some);
          user /= 1000;   // 151,000,001 is making it 151,000 into 151
          a += 3;
          // add bigplaces



        }
      }
      

        
        }
        else if (i == 1 || i == 3)
        {
          
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
        else if ((word.Contains("ered")))
        {
        c = 1;
        }
        else if (word.Contains("ion"))
        {
        c = 1;
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
        else if ( i != 3)
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
      formalWord = some;
      return formalWord;
    }
  }
}