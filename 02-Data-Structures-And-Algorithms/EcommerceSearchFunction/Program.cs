using System;

namespace EcommerceSearchFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Mobile", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Bag", "Fashion")
            };

            Console.Write("Enter Product ID to Search: ");
            string? input = Console.ReadLine();
            int id = int.TryParse(input, out int parsedId) ? parsedId : -1;

            Product? linearResult = Search.LinearSearch(products, id);

            if (linearResult != null)
                Console.WriteLine("Linear Search: " + linearResult.ProductName);
            else
                Console.WriteLine("Product Not Found");

            Product? binaryResult = Search.BinarySearch(products, id);

            if (binaryResult != null)
                Console.WriteLine("Binary Search: " + binaryResult.ProductName);
            else
                Console.WriteLine("Product Not Found");

            Console.ReadLine();
        }
    }
}