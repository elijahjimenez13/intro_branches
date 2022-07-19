using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int numYears;
      
      numYears = 55;
      
      if (numYears == 1) 
      {
        Console.WriteLine("Newlyweds");
      } 
      else if (numYears == 25)
      {
        Console.WriteLine("Silver");
      } 
      else if (numYears == 50)
      {
        Console.WriteLine("Golden");
      } 
      else
      {
        Console.WriteLine("Congrats");
      } 
    }
  }
}