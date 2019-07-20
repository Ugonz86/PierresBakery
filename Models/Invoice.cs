using System;
using System.Collections.Generic;
namespace PierresBakery.Models
{
  class Bread
  {
    private string _bName;
    private int _bPrice;

    public Bread(string bName, int bPrice)
    {
      _bName = bName;
      _bPrice = bPrice;
    }
    public string breadKind()
    {
      return _bName;
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
    private string _pName;
    private int _pPrice;

    public Pastry(string pName, int pPrice)
    {
      _pName = pName;
      _pPrice = pPrice;
    }
    public string pastryKind()
    {
      return _pName;
    }
    public static int PastryInvoice(int pastryNo)
    {
      int total=0;
      total= total + (pastryNo*2);
      return total;
    }
  }
}
