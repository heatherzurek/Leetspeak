using System;
using System.Collections.Generic;

namespace WordWrapper
{
  public class Leetspeak
  {
    public string Translate()
    {
      string userInput = Console.ReadLine();
      // char[] userArray = userInput.ToCharArray();
      for (int i = 0; i < userInput.Length; i++)
      {
        if (userInput[i].ToString() == "e")
        {
          return "3";
        }
        else if (userInput[i].ToString() == "o")
        {
          return "0";
        }
        else if (userInput[i].ToString() == "L")
        {
          return "1";
        }
        else if (userInput[i].ToString() == "t")
        {
          return "7";
        }
        else if (userInput[i].ToString() == "s")
        {
          return "z";
        }
        else
        {
          return userInput[i].ToString();
        }
      }
      return userInput;
    }
  }
}
