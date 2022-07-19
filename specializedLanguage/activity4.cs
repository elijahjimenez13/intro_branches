using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x;
      int y;
      int max;
      
      x = 55;
      y = 79;
      
      if (x > y) 
      {
        max = x;
      } 
      else
      {
        max = y;
      } 
      Console.WriteLine(max);
    }
  }
}