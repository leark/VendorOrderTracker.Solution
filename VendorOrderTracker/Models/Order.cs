using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; }
    public string Desc { get; }
    public int Price { get; }
    public DateTime Date { get; }

    // int[] date consists of length 3 array that holds
    // { year, month, day }
    public Order(string title, string desc, int price, int[] date)
    {
      Title = title;
      Desc = desc;
      Price = price;
      Date = new DateTime(date[0], date[1], date[2]);
    }
  }
}