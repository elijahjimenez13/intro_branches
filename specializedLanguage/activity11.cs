using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int userAge;
      
      userAge = 25;
      
      if (userAge < 16)
      {
      	Console.WriteLine("Enjoy your early years.\n");
      }
      if (userAge > 15)
      {
      	Console.WriteLine("You are old enough to drive.\n");
      }
      if (userAge > 17)
      {
      	Console.WriteLine("You are old enough to vote.\n");
      }
      if (userAge > 24)
      {
      	Console.WriteLine("You can easily rent a car.\n");
      }
      if (userAge > 34)
      {
      	Console.WriteLine("You can run for president.\n");
      }
    }
  }
}