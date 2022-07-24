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
    public int Id { get; }
    private static int _id = 0;
    private static List<Order> _orders = new List<Order>();

    // int[] date consists of length 3 array that holds
    // { year, month, day }
    public Order(string title, string desc, int price, int[] date)
    {
      Title = title;
      Desc = desc;
      Price = price;
      Date = new DateTime(date[0], date[1], date[2]);
      _orders.Add(this);
      _id++;
      Id = _id;
    }

    public static Order Find(int id)
    {
      return _orders.Find(x => x.Id == id);
    }

    public static void Remove(int id)
    {
      _orders.Remove(Find(id));
    }

    public static void ClearAll()
    {
      _orders = new List<Order>();
      _id = 0;
    }
  }
}