using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int kidAge;
      
      kidAge = 9;
      
      if (kidAge < 6) 
      {
        Console.WriteLine("No teams");
      } 
      else if (kidAge < 8)
      {
        Console.WriteLine("Play on U8 team");
      } 
      else if (kidAge < 10)
      {
        Console.WriteLine("Play on U10 team");
      } 
      else if (kidAge < 12)
      {
        Console.WriteLine("Play on U12 team");
      } 
      else
      {
      	Console.WriteLine("No teams");
      }
    }
  }
}