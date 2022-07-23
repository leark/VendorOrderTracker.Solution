using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Create(int id, string title, string desc, int price, int year, int month, int day)
    {
      Order order = new Order(title, desc, price, new int[3] { year, month, day });
      Vendor vendor = Vendor.Find(id);
      vendor.AddOrder(order);
      return RedirectToAction("Show", "Vendors");
    }
  }
}