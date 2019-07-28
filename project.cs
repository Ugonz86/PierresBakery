using System;
using System.Collections.Generic;
using PierresBakery.Models;
namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Bread bread = new Bread();
      Pastry pastry = new Pastry();

      Console.WriteLine("Welcome to Pierres Bakery!");
      Console.WriteLine("Prices: Bread $5 and Pastry $2 (Each one)");
      Console.WriteLine("Would you like to buy bread? Enter Y for yes");
      string breadInput = Console.ReadLine();
      if (breadInput=="yes" || breadInput=="Yes"|| breadInput=="y"|| breadInput=="Y")
      {
        Console.WriteLine("Deal: Buy 2 bread loafs, get 1 free!");
        // Console.WriteLine("Select a bread option: ");
          // Bread bread1 = new Bread("Garlic");
          // Bread bread2 = new Bread("Italian Herbs");
          // Bread bread3 = new Bread("Whole Wheat");
          // List<Bread> BreadList = new List<Bread>{bread1, bread2, bread3};
          // int i = 1;
          // foreach(Bread breadGroup in BreadList)
          // {
          //   Console.WriteLine("----------------------");
          //   Console.WriteLine(breadGroup.Name + " (" + i + ")");
          //   i++;
          // }
          // Console.WriteLine("Select bread type (1-3):");
          // int breadType = Console.ReadLine();

          Console.WriteLine("Enter the # of bread loafs you want to buy: ");
          int breadNo= int.Parse(Console.ReadLine());
          if (breadNo!= 0)
          {
            bread.BreadInvoice(breadNo);
            // if(breadType==1) {
            //   bread1.BreadInvoice(breadNo);
            // }
            // else if(breadType==2) {
            //   bread2.BreadInvoice(breadNo);
            // }
            // else if(breadType==3) {
            //   bread3.BreadInvoice(breadNo);
            // }

              Console.WriteLine("Bread loaf quantity: " + breadNo + " Your bread total is: " + bread.Price + "$");
          }
        }
        else
          {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
          }

      Console.WriteLine("Would you like to buy pastries? Enter Y for yes");
      string pastryInput = Console.ReadLine();
      if (pastryInput=="yes" || pastryInput=="Yes"|| pastryInput=="y"|| pastryInput=="Y")
        {
          Console.WriteLine("Deal: Buy 3 pastries for $5!");
          // Console.WriteLine("Select a pastry option: ");
          //   Pastry pastry1 = new Pastry("Tiramisu", 2);
          //   Pastry pastry2 = new Pastry("Matcha Cake", 2);
          //   Pastry pastry3 = new Pastry("Macaron", 2);
          //   List<Pastry> PastryList = new List<Pastry>{ pastry1, pastry2, pastry3 };
          //   foreach(Pastry PastryGroup in PastryList)
            // {
            //   Console.WriteLine("----------------------");
            //   Console.WriteLine(PastryGroup.Name);
            // }
            // string pastryType = Console.ReadLine();

            Console.WriteLine("Enter the # of pastries you want buy: ");
            int pastryNo = int.Parse(Console.ReadLine());
            if (pastryNo!= 0)
            {
              pastry.PastryInvoice(pastryNo);
            //   int pastryBuy= Pastry.PastryInvoice(pastryNo);
            //   if (pastryNo == 3)
            //   {
            //     Console.WriteLine("You get the 3 for $5 deal!");
            //   }
                Console.WriteLine("Pastry quantity: " + pastryNo + " Your pastry total is:" + pastry.Price + "$");
            }
        }
        int finalTotal = bread.Price + pastry.Price;
        Console.WriteLine("You entire purchase total is: " + finalTotal + "$ ");
        Console.WriteLine("Thank you for buying at Pierres Bakery! Come back soon!");
        // Console.WriteLine("Your total is" + breadBuy + pastryBuy + "$");
    }
  }
}
