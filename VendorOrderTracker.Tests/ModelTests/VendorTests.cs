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
      CollectionAssert.AreEqual(new List<Order> { }, v1.GetAllOrders());
    }

    [TestMethod]
    public void AddOrder_AddOrder_Order()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      Order o1 = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      Order o2 = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      List<Order> oList = new List<Order> { o1, o2 };
      v1.AddOrder(o1);
      v1.AddOrder(o2);

      Assert.AreEqual(o1, v1.GetAllOrders()[0]);
      Assert.AreEqual(o2, v1.GetAllOrders()[1]);
    }

    [TestMethod]
    public void GetAllOrders_ReturnOrders_OrderList()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      Order o1 = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      Order o2 = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      List<Order> oList = new List<Order> { o1, o2 };
      v1.AddOrder(o1);
      v1.AddOrder(o2);

      CollectionAssert.AreEqual(oList, v1.GetAllOrders());
    }

    [TestMethod]
    public void Id_ReturnId_Int()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      Assert.AreEqual(1, v1.Id);
    }

    public void Find_ReturnVendorWithId_Vendor()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      Vendor v2 = new Vendor("Lee's Pizza Parlour");

      Assert.AreEqual(v1, Vendor.Find(1));
    }

    public void Remove_RemoveVendorWithId_Void()
    {
      Vendor v1 = new Vendor("Suzie's Cafe");
      Vendor v2 = new Vendor("Lee's Pizza Parlour");

      Assert.AreEqual(v1, Vendor.Find(1));
    }
  }
}