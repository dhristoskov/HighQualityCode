using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using ProductCatalog.Models;

namespace ProductCatalog
{
    class MainClass
    {
        private static List<Category> _categories;
        private static List<Product> _products;
        private static List<Order> _orders;
        private static readonly string UnderLine = new string('-', 20);

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            DataMapper dateMapper = new DataMapper();
            _categories = dateMapper.GetAllCategories();
            _products = dateMapper.GetAllProducts();
            _orders = dateMapper.GetAllOrders();

            PrintMostExpensive();          
            PrintNumberOfProducts();
            PrintTopProducts();
            PrintMostProfitable();
        }

        /// <summary>
        /// Printing the most profitable category
        /// of products
        /// </summary>
        private static void PrintMostProfitable()
        {
            var mostProfitable = _orders
                .GroupBy(order => order.ProductId)
                .Select( group => new
                        {
                            catalogId = _products.First(product => product.Id == group.Key).CategoryId,
                            price = _products.First(product => product.Id == group.Key).UnitPrice,
                            quantity = group.Sum(product => product.Quant)
                        })
                .GroupBy(gg => gg.catalogId)
                .Select( grp => new
                        {
                            categoryName = _categories.First(category => category.Id == grp.Key).Name,
                            totalQuantity = grp.Sum(g => g.quantity*g.price)
                        })
                .OrderByDescending(g => g.totalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitable.categoryName, mostProfitable.totalQuantity);
        }

        /// <summary>
        /// Printing top five products
        /// ordered by quentity
        /// </summary>
        private static void PrintTopProducts()
        {
            var topProducts = _orders
                .GroupBy(order => order.ProductId)
                .Select(grp => new {Product = _products.First(product => product.Id == grp.Key).Name,
                 Quantities = grp.Sum(group => group.Quant)}).OrderByDescending(quantity => quantity.Quantities).Take(5).ToList();
            foreach (var product in topProducts)
            {
                Console.WriteLine("{0}: {1}", product.Product, product.Quantities);
            }
            Console.WriteLine(UnderLine);
        }

        /// <summary>
        /// Printing total number 
        /// of products in each category
        /// </summary>
        private static void PrintNumberOfProducts()
        {
            var productsInCategory = _products.GroupBy(product => product.CategoryId)
                .Select(grp => new {Category = _categories.First(category => category.Id == grp.Key).Name,
                 Count = grp.Count()}).ToList();
            foreach (var product in productsInCategory)
            {
                Console.WriteLine("{0}: {1}", product.Category, product.Count);
            }
            Console.WriteLine(UnderLine);
        }

        /// <summary>
        ///Printing names of the
        ///five most expensive products
        /// </summary>
        private static void PrintMostExpensive()
        {
            var mostExpensive = _products.OrderByDescending(product => product.UnitPrice)
                .Take(5).Select(product => product.Name).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensive));
            Console.WriteLine(UnderLine);
        }
    }
}
