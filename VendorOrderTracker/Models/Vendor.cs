using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public int Id { get; }
    private List<Order> Orders;
    private static List<Vendor> _vendors = new List<Vendor>();
    private static int _id = 0;
    public Vendor(string name)
    {
      Name = name;
      Orders = new List<Order>();
      _vendors.Add(this);
      _id++;
      Id = _id;
    }

    public List<Order> GetAllOrders()
    {
      return Orders;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public void RemoveOrder(Order order)
    {
      Order.Remove(order.Id);
      Orders.Remove(order);
    }

    public void RemoveAllOrders()
    {
      foreach (Order order in Orders)
      {
        Order.Remove(order.Id);
      }
      Orders = new List<Order>();
    }

    public static List<Vendor> GetAllVendors()
    {
      return _vendors;
    }

    public static void ClearAllVendors()
    {
      _vendors = new List<Vendor>();
      _id = 0;
    }

    public static Vendor Find(int id)
    {
      return _vendors.Find(x => x.Id == id);
    }

    public static void Remove(int id)
    {
      Vendor vendor = Find(id);
      vendor.RemoveAllOrders();
      _vendors.Remove(vendor);
    }
  }
}