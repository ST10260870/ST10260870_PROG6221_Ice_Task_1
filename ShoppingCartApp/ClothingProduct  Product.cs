using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp { }

// Derived class for clothing products
    public class ClothingProduct : Products
{
    private readonly string size;
    private readonly string color;

    // Properties
    public string Size { get => size; }
    public string Color { get => color; }

    // Constructor
    public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
        : base(name, price, category)
    {
        this.size = size;
        this.color = color;
    }

    // Override method to get information about the clothing product
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Size: {Size}, Color: {Color}");
    }
}
