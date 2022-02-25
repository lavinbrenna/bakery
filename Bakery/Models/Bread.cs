using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Bread
  {
    public int LoafCount {get; set;}

    public Bread(int loafCount)
    {
      LoafCount = loafCount;
    }
  }
}