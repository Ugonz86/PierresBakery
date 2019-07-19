using System;
using PierresBakery.Models;
namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery!");
      Console.WriteLine("Prices: Bread $5 and Pastry $2 (Each one)");
      Console.WriteLine("Would you like to buy bread? Enter Y for yes");
      string bread = Console.ReadLine();
      if (bread=="yes" || bread=="Yes"|| bread=="y"|| bread=="Y")
      {
        Console.WriteLine("Deal: Buy 2 bread loafs, get 1 free!");
        Console.WriteLine("Enter the # of bread loafs you want buy: ");
        int breadNo= int.Parse(Console.ReadLine());
        if (breadNo!= 0)
        {
          int breadBuy= Bread.BreadInvoice(breadNo);
          if (breadNo == 2)
          {
            Console.WriteLine("You get an extra bread loaf for free!");
          }
          Console.WriteLine("Bread loaf quantity: " + breadNo + " your total is: " + breadBuy + "$");
        }
      }
      Console.WriteLine("Would you like to buy pastries? Enter Y for yes");
      string pastry = Console.ReadLine();
      if (pastry=="yes" || pastry=="Yes"|| pastry=="y"|| pastry=="Y")
        {
          Console.WriteLine("Enter the # of pastries you want buy: ");
          int pastryNo= int.Parse(Console.ReadLine());
          if (pastryNo!= 0)
          {
            int pastryBuy= Pastry.PastryInvoice(pastryNo);
            if (pastryNo == 3)
            {
              Console.WriteLine("You get the 3 for $5 deal!");
            }
            Console.Write("Pastry quantity: " + pastryNo + " your total is:" + pastryBuy + "$");
          }
        }
    }
  }
}
