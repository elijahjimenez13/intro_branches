using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int hotelRate;
      int userAge;
      
      hotelRate = 155;
      userAge = 68;
      
      if (userAge > 65) 
      {
        hotelRate = hotelRate - 20;
      } 
      Console.WriteLine("Your rate: " + hotelRate);
    }
  }
}