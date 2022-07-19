using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int userAge;
      int insurePrice;
      
      userAge = 22;
      
      if (userAge < 25) 
      {
        insurePrice = 4800;
      } 
      else
      {
        insurePrice = 2200;
      } 
      Console.WriteLine("Annual price: $" + insurePrice);
    }
  }
}