using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order order = new Order("", "", 0, new int[3] { 2022, 7, 22 });
      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void OrderConstructor_InitializeOrderTitle_Order()
    {
      Order order = new Order("Croissants", "", 0, new int[3] { 2022, 7, 22 });
      Assert.AreEqual("Croissants", order.Title);
    }

    [TestMethod]
    public void OrderConstructor_InitializeOrderDesc_Order()
    {
      Order order = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 0, new int[3] { 2022, 7, 22 });
      Assert.AreEqual("12 Nutella filled, 12 strawberry jam filled", order.Desc);
    }

    [TestMethod]
    public void OrderConstructor_InitializeOrderPrice_Order()
    {
      Order order = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      Assert.AreEqual(72, order.Price);
    }

    [TestMethod]
    public void OrderConstructor_InitializeOrderDate_Order()
    {
      Order order = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      Assert.AreEqual(new DateTime(2022, 7, 22), order.Date);
    }

    [TestMethod]
    public void Find_ReturnOrderFromId_Order()
    {
      Order order = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      Assert.AreEqual(Order.Find(1), order);
    }

    [TestMethod]
    public void Remove_RemoveOrderById_Order()
    {
      Order order = new Order("Croissants", "12 Nutella filled, 12 strawberry jam filled", 72, new int[3] { 2022, 7, 22 });
      Order.Remove(1);
      Assert.AreEqual(Order.Find(1), null);
    }
  }
}