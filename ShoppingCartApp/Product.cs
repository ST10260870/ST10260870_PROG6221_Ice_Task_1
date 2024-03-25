using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp

// Base class for all products
public class Product
{
    private string name;
    private double price;
    private ProductCategory category;

    // Properties
    public string Name { get => name; }
    public double Price { get => price; }
    public ProductCategory Category { get => category; }

    // Constructor
    public Product(string name, double price, ProductCategory category)
    {
        this.name = name;
        this.price = price;
        this.category = category;
    }

    // Method to get information about the product
    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, Category: {Category}");
    }

}

}