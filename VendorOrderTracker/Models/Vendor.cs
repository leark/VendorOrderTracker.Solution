using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    private List<Order> Orders;
    // private int Id;
    private static List<Vendor> _vendors = new List<Vendor> { };
    public Vendor(string name)
    {
      Name = name;
      Orders = new List<Order> { };
      _vendors.Add(this);
    }

    public List<Order> GetOrders()
    {
      return Orders;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static List<Vendor> GetAllVendors()
    {
      return _vendors;
    }

    public static void ClearAllVendors()
    {
      _vendors = new List<Vendor> { };
    }
  }
}