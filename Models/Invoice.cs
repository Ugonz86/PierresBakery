using System;
namespace PierresBakery.Models
{
  class Invoice
  {
    public static void Total(int bread, int pastry)
    {
      int total=0;
      if (bread!=0)
      {
        total = total + (bread*5);
      }
        if (pastry!=0)
        {
          total = total + (pastry*2);
        }
        Console.WriteLine("Your total is: " + total);
    }
  }
}
