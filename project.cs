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
      Console.WriteLine("Deal: Buy 2 bread loafs, get 1 free OR buy 3 pastries for $5.");
      Console.WriteLine("Enter the # of bread loafs you want buy: ");
      int breadNo= int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the # of pastries you want buy: ");
      int pastryNo= int.Parse(Console.ReadLine());
      Invoice.Total(breadNo,pastryNo);
    }
  }
}
