using System.Collections.Generic;
using System.Linq;

namespace OrderTracker
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public void AddOrder(Order order)
    {
      Order.Add(order);
    }
  }
}