namespace Excercise3.Models;

public class ShoppingCart
{
    public List<Product> Products { get; set; } = new List<Product>();
    public decimal TotalPrice => Products.Sum(Products => Products.Price);
}
