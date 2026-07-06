using System;

namespace ECommerceSearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Laptop","Electronics"),
                new Product(102,"Mobile","Electronics"),
                new Product(103,"Shoes","Fashion"),
                new Product(104,"Watch","Accessories"),
                new Product(105,"Keyboard","Electronics")
            };

            Console.WriteLine("Linear Search");

            Product result1 = SearchAlgorithms.LinearSearch(products, 104);

            if (result1 != null)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine(result1.ProductName + " - " + result1.Category);
            }

            Console.WriteLine();

            Console.WriteLine("Binary Search");

            Product result2 = SearchAlgorithms.BinarySearch(products, 104);

            if (result2 != null)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine(result2.ProductName + " - " + result2.Category);
            }
        }
    }
}