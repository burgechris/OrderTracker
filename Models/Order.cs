using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set ;}
    public double Cost { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    public static List<Order> _instances = new List<Order> {};
    public static int _idCounter = 0;

    public Order (string title, string description, double cost, string date)
    {
      Title = title;
      Description = description;
      Cost = cost;
      Date = date;
      _instances.Add(this);
      _idCounter ++;
      Id = _idCounter;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    // public static Order Find(int searchId)
    // {
    //   return _instances.Where(order => order.Id == searchId).FirstOrDefault();
    // }
  }
}