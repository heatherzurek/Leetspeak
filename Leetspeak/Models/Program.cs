using System;
using System.Collections.Generic;

namespace WordWrapper
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a word to translate to leetspeak!");
      Leetspeak leetspeak = new Leetspeak();
      leetspeak.Translate();
      Console.WriteLine(leetspeak.Translate());
    }
  }
}
