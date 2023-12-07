using ExerciseOopHierarchy;
using System;
using System.Collections.Generic;

public class Restaurant
{
    private List<Customer> _customers = new();
    private List<MenuItem> _menu = new();

    public void AddCustomer(Customer customer1)
    {
       _customers.Add(customer1);
    }

    public void AddMenuItem(MenuItem main)
    { 
        _menu.Add(main); 
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Items:");
        foreach (MenuItem item in _menu)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void DisplayOrderHistory(Customer customer1)
    {
        Console.WriteLine($"{customer1.Name}'s Order History:");
        foreach (Order order1 in customer1.OrdersHistory)
        {
            Console.WriteLine($"Order Total: ${order1.GetTotal()}");
            foreach (MenuItem menuItem in order1.Items)
            {
                
                Console.WriteLine($"  {menuItem}");
            }
        }
    }

    public MenuItem GetMenuItem(int index)
    {
        if (index < 0 || index >= _menu.Count)
        {
            throw new IndexOutOfRangeException();
        }
        return _menu[index];
    }


    public void PlaceOrder(Customer customer1, Order order)
    {
        customer1.AddOrder(order);
    }
}