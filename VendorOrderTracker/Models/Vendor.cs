using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _vendors = new List<Vendor> { };
    public Vendor(string name)
    {
      Name = name;
      _vendors.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

  }
}