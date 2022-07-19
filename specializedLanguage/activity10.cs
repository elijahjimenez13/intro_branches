using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int riderAge;
      int riderHeight;
      
      riderAge = 25;
      riderHeight = 47;
      
      if (riderAge < 10)
      {
      	Console.WriteLine("Cant ride. Too young");
      }
      else if (riderAge < 80)
      {
      	if (riderHeight < 48)
        {
        	Console.WriteLine("Cant ride: Too short");
        }
        else 
        {
        	Console.WriteLine("Can ride");
        }
      }
      else
      {
      	Console.WriteLine("Can ride, but sure?");
      }
    }
  }
}