using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int numStrokes;
      
      numStrokes = 2;
      
      // Assumes 'par 4'
      if (numStrokes <= 0) 
      {
        Console.WriteLine("Invalid entry.");
      } 
      else if (numStrokes == 1)
      {
        Console.WriteLine("Hole in 1!!!");
      } 
      else if (numStrokes == 2)
      {
        Console.WriteLine("Eagle!");
      } 
      else if (numStrokes == 3)
      {
        Console.WriteLine("Birdie.");
      } 
      else if (numStrokes == 4)
      {
      	Console.WriteLine("Par.");
      }
      else 
      {
      	Console.WriteLine("Better luck next time.");
      }
    }
  }
}