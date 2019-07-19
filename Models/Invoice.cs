using System;
using System.Collections.Generic;
namespace PierresBakery.Models
{
  class Bread
  {
    private int _bPrice;
    public Bread(int bPrice)
    {
      _bPrice = bPrice;
    }
    public static int BreadInvoice(int breadNo)
    {
      int total=0;
      total= total + (breadNo*5);
      return total;
    }
  }

  class Pastry
  {
    private int _pPrice;
    public Pastry(int pPrice)
    {
      _pPrice = pPrice;
    }
    public static int PastryInvoice(int pastryNo)
    {
      int total=0;
      total= total + (pastryNo*2);
      return total;
    }
  }
}
