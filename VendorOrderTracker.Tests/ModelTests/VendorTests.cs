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
      Vendor.ClearAllVendors();
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
    public void GetAllVendors_ReturnVendors_VendorList()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      Vendor v2 = new Vendor("Lee's Pizza Parlour");
      List<Vendor> vList = new List<Vendor> { v1, v2 };
      CollectionAssert.AreEqual(vList, Vendor.GetAllVendors());
    }

    [TestMethod]
    public void GetOrders_ReturnEmptyOrder_OrderList()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      CollectionAssert.AreEqual(new List<Order> { }, v1.GetOrders());
    }

    [TestMethod]
    public void GetOrders_ReturnOrders_OrderList()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      Order o1 = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      Order o2 = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      List<Order> oList = new List<Order> { o1, o2 };
      v1.AddOrder(o1);
      v1.AddOrder(o2);

      CollectionAssert.AreEqual(oList, v1.GetOrders());
    }
  }
}