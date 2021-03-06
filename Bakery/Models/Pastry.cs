using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCount {get; set;}
    public string PastryType {get; set;}
    private static List<Pastry> _instances = new List<Pastry>{};
    public Pastry(int pastryCount, string pastryType)
    {
      PastryCount = pastryCount;
      PastryType = pastryType;
      _instances.Add(this);
    }
    public static int GetPastryPrice(int pastryCount)
    {
      int pastryPrice = 0;
      List<int> pastryList = new List<int>{};
      for(int i = 0; i <= pastryCount; i ++)
      {
        pastryList.Add(i);
      }
      foreach(int pastry in pastryList)
      {
        if(pastry % 3 == 0)
        {
          int pastryMultiplier = pastry / 3;
          pastryPrice = pastryMultiplier * 5;
        }
        else
        {
          pastryPrice += 2;
        }
      }
      return pastryPrice;
    }

    public static List<Pastry> GetAllPastries()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
