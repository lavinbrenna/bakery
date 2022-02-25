using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]

  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1, "Shokupan");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetLoafCount_ReturnCountOfLoavesOfBread_Int()
    {
      Bread newBread = new Bread(1, "Shokupan");
      int loafNumber = newBread.LoafCount;
      Assert.AreEqual(loafNumber, 1);
    }
    [TestMethod]
    public void GetLoafPrice_ReturnPriceOfLoaves_Int()
    {
      Bread newBread = new Bread(1, "Shokupan");
      Bread multipleLoaves = new Bread(6, "Brioche");
      int loafNumber = newBread.LoafCount;
      int loavesNumber = multipleLoaves.LoafCount;
      int breadPrice = Bread.GetLoafPrice(loafNumber);
      int loavesPrice = Bread.GetLoafPrice(loavesNumber);
      Assert.AreEqual(breadPrice, 5);
      Assert.AreEqual(loavesPrice, 20);
    }
    [TestMethod]
    public void GetBreadType_ReturnBreadType_String()
    {
      Bread newBread = new Bread(1, "Shokupan");
      string breadStyle = newBread.BreadType;
      Assert.AreEqual(breadStyle, "Shokupan");
    }
    [TestMethod]
    public void GetAllBread_ReturnsEmptyBreadList_BreadList()
    {
      List<Bread> newList = new List<Bread> {};
      List<Bread> result = Bread.GetAllBread();
      foreach(Bread thisBread in result)
      {
        Console.WriteLine("Output from empty list GetAllBread test: " + thisBread.BreadType);
      }
      CollectionAssert.AreEqual(newList, result);
    }
  }
}