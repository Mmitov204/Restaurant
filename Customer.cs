using System.Collections.Generic;

public class Customer
{
    private List<Order> _ordersHistory;

    public IReadOnlyCollection<Order> OrdersHistory => _ordersHistory.AsReadOnly();

    public string Name { get; set; }
    public string Email { get; set; }

    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
        _ordersHistory = new List<Order>();
    }
    public void AddOrder(Order order)
    {
        _ordersHistory.Add(order);
    }
}
