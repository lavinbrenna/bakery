using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;


namespace Bakery.Tests
{
  [TestClass]

  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1, "Croissant");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryCount_ReturnCountOfPastries_Int()
    {
      Pastry newPastry = new Pastry(1, "Croissant");
      int pastryNumber = newPastry.PastryCount;
      Assert.AreEqual(pastryNumber,1);
    }

    [TestMethod]
    public void GetPastryPrice_ReturnPriceOfPastries_Int()
    {
      Pastry newPastry = new Pastry(3, "Croissant");
      Pastry multiplePastries = new Pastry(5, "Cronut");
      int newPastryNumber = newPastry.PastryCount;
      int multiplePastryNumber = multiplePastries.PastryCount;
      int pastryPrice = Pastry.GetPastryPrice(newPastryNumber);
      int multiplePastryPrice = Pastry.GetPastryPrice(multiplePastryNumber);
      Assert.AreEqual(pastryPrice, 5);
      Assert.AreEqual(multiplePastryPrice, 9);
    }

    [TestMethod]
    public void GetPastryType_ReturnPastryType_String()
    {
      Pastry newPastry = new Pastry(1, "Croissant");
      string pastryStyle = newPastry.PastryType;
      Assert.AreEqual(pastryStyle, "Croissant");
    }
    [TestMethod]
    public void GetAllPastries_ReturnsEmptyPastryList_PastryList()
    {
      List<Pastry> newList = new List<Pastry>{};
      List<Pastry> result = Pastry.GetAllPastries();
      foreach(Pastry thisPastry in result)
      {
        Console.WriteLine("Output from empty list GetAllPastries test: "+ thisPastry.PastryType);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAllPastries_ReturnsPastryTypes_PastryList()
    {
      string pastryStyle1 = "Croissant";
      string pastryStyle2 = "Cheese Danish";
      int pastryCount1 = 1;
      int pastryCount2 = 1;
      Pastry newPastry1 = new Pastry(pastryCount1, pastryStyle1);
      Pastry newPastry2 = new Pastry(pastryCount2, pastryStyle2);
      List<Pastry> newList = new List<Pastry>{
        newPastry1, newPastry2
      };
      List<Pastry> result = Pastry.GetAllPastries();
      foreach(Pastry thisPastry in result)
      {
        Console.WriteLine("Output from second GetAllPastries test: "+ thisPastry.PastryType);
      }
      CollectionAssert.AreEqual(newList, result);
    }
  }
}