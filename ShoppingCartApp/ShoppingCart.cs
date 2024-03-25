using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    // Class representing a shopping cart
    public class ShoppingCart
    {
        private Product[] products;
        private int itemCount;

        // Properties
        public Product[] Products { get => products; }
        public int ItemCount { get => itemCount; }

        // Constructor
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }

        // Method to add a product to the shopping cart
        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount] = product;
                itemCount++;
                Console.WriteLine($"{product.Name} added to the shopping cart.");
            }
            else
            {
                Console.WriteLine("The shopping cart is full.");
            }
        }

        // Method to remove a product from the shopping cart
        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (products[i] == product)
                {
                    // Shift elements to the left to remove the product
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    itemCount--;
                    Console.WriteLine($"{product.Name} removed from the shopping cart.");
                    return;
                }
            }
            Console.WriteLine("Product not found in the shopping cart.");
        }

        internal void AddProduct(ClothingProduct shirt)
        {
            throw new NotImplementedException();
        }
    }

}
