using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetLoafCount_ReturnCountOfLoavesOfBread_Int()
    {
      Bread newBread = new Bread(1);
      int loafNumber = newBread.LoafCount;
      Assert.AreEqual(loafNumber, 1);
    }
  }
}