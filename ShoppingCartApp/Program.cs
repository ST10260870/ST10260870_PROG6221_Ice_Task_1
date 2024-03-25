
using ShoppingCartApp;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate products
        var shirt = new ClothingProduct("Shirt", 19.99, ProductCategory.Clothing, "M", "Blue");
        var laptop = new ElectronicsProduct("Laptop", 999.99, ProductCategory.Electronics, "Dell", "XPS 15");

        // Instantiate a shopping cart
        var cart = new ShoppingCart(5);

        // Add products to the shopping cart
        cart.AddProduct(shirt);
        cart.AddProduct(laptop);s

        // Display the contents of the shopping cart
        Console.WriteLine("\nContents of the shopping cart:");
        foreach (var product in cart.Products)
        {
            if (product != null)
                product.GetInfo();
        }

        // Remove a product from the shopping cart
        cart.RemoveProduct(shirt);

        // Display the updated contents of the shopping cart
        Console.WriteLine("\nUpdated contents of the shopping cart:");
        foreach (var product in cart.Products)
        {
            if (product != null)
                product.GetInfo();
        }
    }
}
