using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      // Deck.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor v = new Vendor("");
      Assert.AreEqual(typeof(Vendor), v.GetType());
    }

    [TestMethod]
    public void VendorConstructor_InitializeVendorName_String()
    {
      Vendor v = new Vendor("Suzie's Cafe");
      Assert.AreEqual("Suzie's Cafe", v.Name);
    }
  }
}