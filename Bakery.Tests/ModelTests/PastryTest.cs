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
  }
}