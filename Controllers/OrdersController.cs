using Microsoft.AspNetCore.Mvc;
using BigfootTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    
  }
}