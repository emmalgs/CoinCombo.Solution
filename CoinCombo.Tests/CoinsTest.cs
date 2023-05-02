using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo.Models;
using System.Collections.Generic;
using System;

namespace CoinCombo.Tests
{
  [TestClass]
  public class CoinsTest : IDisposable
  {
    public void Dispose()
    {
      Coin.ClearAll();
    }
    [TestMethod]
    public void CoinClass_CreatesNewCoin_Coin()
    {
      Coin newQuarter = new Coin();
      Assert.AreEqual(typeof(Coin), newQuarter.GetType());
    }

    // [TestMethod]
    // public void QuarterMethod_ReturnsQuarterValue_Quarter()
    // {
    //   Coin newQuarter = new Coin();
    //   float expected = 0.25F;
    //   float quarter = newQuarter.Quarter(expected);
    //   Assert.AreEqual(expected, quarter);
    // }
    // [TestMethod]
    // public void QuarterMethod_ReturnsFloatAmount_Quarter()
    // {
    //   Coin newQuarter = new Coin();
    //   int expected = 1;
    //   float amount = 0.25F;
    //   Assert.AreEqual(expected, newQuarter.Quarter(amount));

    // }
    // [TestMethod]
    // public void QuarterMethod_MathOutputsCorrectNumber_Quarter()
    // {
    //   Coin newQuarter = new Coin();
    //   int expected = 3;
    //   float amount = 0.75F;
    //   Assert.AreEqual(expected, newQuarter.Quarter(amount));
    // }
    // [TestMethod]
    // public void QuarterMethod_ReturnsStringQuarterAmount_Quarter()
    // {
    //   Coin newQuarter = new Coin();
    //   string expected = "3 quarters";
    //   float amount = 0.75F;
    //   Assert.AreEqual(expected, newQuarter.Quarter(amount));
    // }
    [TestMethod]
    public void QuarterMethod_AddsQuartersToList_String()
    {
      Coin newQuarter = new Coin();
      string expected = "3 quarter(s)";
      decimal amount = 0.75m;
      newQuarter.Quarter(amount);
      Assert.AreEqual(expected, Coin.Piggybank[0]);
    }
    // [TestMethod]
    // public void QuarterMethod_ReturnsDecimalRemainder_Decimal()
    // {
    //   Coin newQuarter = new Coin();
    //   decimal expected = 0.07m;
    //   decimal amount = 1.32m;
    //   decimal actual = newQuarter.Quarter(amount);
    //   Assert.AreEqual(expected, actual);
    // }

    [TestMethod]
    public void DimeMethod_AddsDimesToList_String()
    {
      Coin change = new Coin();
      string expected = "1 dime(s)";
      decimal amount = 1.42m;
      change.Quarter(amount);
      Assert.AreEqual(expected, Coin.Piggybank[1]);
    }

    [TestMethod]
    public void DimeMethod_RetunrDecimalRemainder_Decimal()
    {
      Coin change = new Coin();
      decimal expected = 0.07m;
      decimal amount = 1.47m;
      Assert.AreEqual(expected, change.Dime(amount));
    }
        [TestMethod]
    public void NickelMethod_AddsNickelToList_String()
    {
      Coin change = new Coin();
      string expected = "1 nickel(s)";
      decimal amount = 0.07m;
      change.Nickel(amount);
      Assert.AreEqual(expected, Coin.Piggybank[0]);
    }
        public void PennyMethod_AddsPennyToList_String()
    {
      Coin change = new Coin();
      string expected = "1 penny(s)";
      decimal amount = 0.01m;
      change.Penny(amount);
      Assert.AreEqual(expected, Coin.Piggybank[0]);
    }
  }
}
