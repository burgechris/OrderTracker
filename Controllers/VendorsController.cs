using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    // [HttpPost("/items/remove")]
    // public ActionResult Remove(List<int> ids)
    // {
    //   foreach (int id in ids)
    //   {
    //     Item deleteItem = Item.Find(id);
    //     Item._instances.Remove(deleteItem);
    //   }
    //   Item.BackpackWeight();
    //   return View();
    // }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order foundOrder = Order.Find(id);
      return View(foundOrder);
    }
  }
}