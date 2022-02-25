using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCount {get; set;}

    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
    }
    public static int GetPrice(int pastryCount)
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
  }
}
