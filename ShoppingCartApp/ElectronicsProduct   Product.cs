using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp

// Derived class for electronics products
 public class ElectronicsProduct : Product
{
    private readonly string brand;
    private readonly string model;

    // Properties
    public string Brand { get => brand; }
    public string Model { get => model; }

    // Constructor
    public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
        : base(name, price, category)
    {
        this.brand = brand;
        this.model = model;
    }

    // Override method to get information about the electronics product
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Brand: {Brand}, Model: {Model}");
    }
}

}