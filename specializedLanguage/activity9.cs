using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int userAge;
      int insurancePrice;
      
      userAge = 22;
      
      if (userAge < 16) 
      {
      	// 15 and under
        Console.WriteLine("Too young");
        insurancePrice = 0;
      } 
      else if (userAge < 25)
      {
        // 16...24
        insurancePrice = 4800;
      } 
      else if (userAge < 40)
      {
        // 25...39
        insurancePrice = 2350;
      } 
      else
      {
      	// 40 and up
        insurancePrice = 2100;
      }
      
      Console.WriteLine("Annual price: $" + insurancePrice);
    }
  }
}