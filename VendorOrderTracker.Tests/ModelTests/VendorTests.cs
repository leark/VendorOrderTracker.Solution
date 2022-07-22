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

    [TestMethod]
    public void GetAll_GetAllVendors_VendorList()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      Vendor v2 = new Vendor("Lee's Pizza Parlour");
      List<Vendor> vList = new List<Vendor> { v1, v2 };
      CollectionAssert.AreEqual(vList, Vendor.GetAll());
    }
  }
}