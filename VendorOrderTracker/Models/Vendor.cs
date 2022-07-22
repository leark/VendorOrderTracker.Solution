using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public Vendor(string name)
    {
      Name = name;
    }
  }
}