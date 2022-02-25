using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]

  public class Pastry
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    public void GetCost_GetCostOfSinglePastry_Int()
    {
      Pastry newPastry = new Pastry();
      int price = newPastry.GetCost;
      Assert.AreEqual(price, 2);
    }

  }
}