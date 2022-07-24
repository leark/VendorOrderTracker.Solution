using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor vendor = new Vendor(vendorName);
      return RedirectToAction("Index", "Home");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
    }

    [HttpPost("/vendors/{id}")]
    public ActionResult Destroy(int id)
    {

      return RedirectToAction("Index", "Home");
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int id, string title, string desc, int price, string date)
    {
      string[] dateSA = date.Split("-");
      int[] dateIA = new int[3] { int.Parse(dateSA[0]), int.Parse(dateSA[1]), int.Parse(dateSA[2]) };
      Order order = new Order(title, desc, price, dateIA);
      Vendor vendor = Vendor.Find(id);
      vendor.AddOrder(order);
      return RedirectToAction("Show", vendor);
    }
  }
}