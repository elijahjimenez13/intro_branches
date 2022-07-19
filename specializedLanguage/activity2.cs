using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int val;
      
      val = -99;
      
      if (val < 0) 
      {
        val = -val;
      } 
      Console.WriteLine(val);
    }
  }
}