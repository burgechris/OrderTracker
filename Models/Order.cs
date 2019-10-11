using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Item { get; set ;}
    public double Cost { get; set; }
    public int Id { get; }
    public static List<Order> _instances = new List<Order> {};
    public static int _idCounter = 0;

    public Order (string name, string item, double Cost)
    {
      Name = name;
      Item = item;
      Cost = cost;
      _instances.Add(this);
      _idCounter ++;
      Id = _idCounter;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances.Where(order => order.Id == searchId).FirstOrDefault();
    }
  }
}