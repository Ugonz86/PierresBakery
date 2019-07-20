using System;
using System.Collections.Generic;
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
        Console.WriteLine("Select a bread option: ");
          Bread bread1 = new Bread("Garlic", 5);
          Bread bread2 = new Bread("Italian Herbs", 5);
          Bread bread3 = new Bread("Whole Wheat", 5);
          List<Bread> BreadList = new List<Bread>{bread1, bread2, bread3};
          foreach(Bread breadGroup in BreadList)
          {
            Console.WriteLine("----------------------");
            Console.WriteLine(breadGroup.breadKind());
          }
          string breadtype = Console.ReadLine();

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
          Console.WriteLine("Deal: Buy 3 pastries for $5!");
          Console.WriteLine("Select a pastry option: ");
            Pastry pastry1 = new Pastry("Tiramisu", 2);
            Pastry pastry2 = new Pastry("Matcha Cake", 2);
            Pastry pastry3 = new Pastry("Macaron", 2);
            List<Pastry> PastryList = new List<Pastry>{ pastry1, pastry2, pastry3 };
            foreach(Pastry PastryGroup in PastryList)
            {
              Console.WriteLine("----------------------");
              Console.WriteLine(PastryGroup.pastryKind());
            }
            string pastryType = Console.ReadLine();

            Console.WriteLine("Enter the # of pastries you want buy: ");
            int pastryNo= int.Parse(Console.ReadLine());
            if (pastryNo!= 0)
            {
              int pastryBuy= Pastry.PastryInvoice(pastryNo);
              if (pastryNo == 3)
              {
                Console.WriteLine("You get the 3 for $5 deal!");
              }
                Console.WriteLine("Pastry quantity: " + pastryNo + " your total is:" + pastryBuy + "$");
            }
        }
        Console.WriteLine("Thank you for buying at Pierres Bakery! Come back soon!");
        // Console.WriteLine("Your total is" + breadBuy + pastryBuy + "$");
    }
  }
}
