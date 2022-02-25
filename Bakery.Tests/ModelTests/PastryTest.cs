using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


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
    // [TestMethod]
    // public void GetAllPastries_ReturnsEmptyPastryList_PastryList()
    // {
    //   List<Pastry> newList = new List<Pastry>{};
    //   List<Pastry> result = Pastry.GetAllPastries();
    //   foreach(Pastry thisPastry in result)
    //   {
    //     Console.WriteLine("Output from empty list GetAllPastries test: "+ thisPastry.PastryType)
    //   }
    // }
  }
}