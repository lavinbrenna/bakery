using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]

  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryCount_ReturnCountOfPastries_Int()
    {
      Pastry newPastry = new Pastry(1);
      int pastryNumber = newPastry.PastryCount;
      Assert.AreEqual(pastryNumber,1);
    }

    [TestMethod]
    public void GetPastryPrice_ReturnPriceOfPastries_Int()
    {
      Pastry newPastry = new Pastry(3);
      Pastry multiplePastries = new Pastry(5);
      int newPastryNumber = newPastry.PastryCount;
      int multiplePastryNumber = multiplePastries.PastryCount;
      int pastryPrice = Pastry.GetPrice(newPastryNumber);
      int multiplePastryPrice = Pastry.GetPrice(multiplePastryNumber);
      Assert.AreEqual(pastryPrice, 5);
      Assert.AreEqual(multiplePastryPrice, 9);
    }
  }
}