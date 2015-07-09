using System.Collections.Generic;
using System.Linq;
using ProductCatalog.Models;
using System.IO;

namespace ProductCatalog
{
    public class DataMapper
    {
        private readonly string _categoriesFileName;
        private readonly string _productsFileName;
        private readonly string _ordersFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this._categoriesFileName = categoriesFileName;
            this._productsFileName = productsFileName;
            this._ordersFileName = ordersFileName;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }


        /// <summary>
        /// Method that return Categories list
        /// </summary>
        /// <returns>List <Categoty> </returns>
        public List<Category> GetAllCategories()
        {
            List<string> categories = ReadFileLines(this._categoriesFileName, true);
            return categories
                .Select(category => category.Split(','))
                .Select(category => new Category
                {
                    Id = int.Parse(category[0]),
                    Name = category[1],
                    Description = category[2]
                }).ToList();
        }


        /// <summary>
        /// Method that return Products list
        /// </summary>
        /// <returns>List <Product></returns>
        public List<Product> GetAllProducts()
        {
            List<string> products = ReadFileLines(this._productsFileName, true);
            return products
                .Select(product => product.Split(','))
                .Select(product => new Product
                {
                    Id = int.Parse(product[0]),
                    Name = product[1],
                    CategoryId = int.Parse(product[2]),
                    UnitPrice = decimal.Parse(product[3]),
                    UnitsInStock = int.Parse(product[4]),
                }).ToList();
        }


        /// <summary>
        /// Method that return Order list
        /// </summary>
        /// <returns>List <Order></returns>
        public List<Order> GetAllOrders()
        {
            List<string> orders = ReadFileLines(this._ordersFileName, true);
            return orders
                .Select(order => order.Split(','))
                .Select(order => new Order
                {
                    Id = int.Parse(order[0]),
                    ProductId = int.Parse(order[1]),
                    Quant = int.Parse(order[2]),
                    Discount = decimal.Parse(order[3]),
                }).ToList();
        }


        /// <summary>
        /// Method that read data
        /// and return List<string>
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="hasHeader"></param>
        /// <returns>List<string></returns>
        private List<string> ReadFileLines(string fileName, bool hasHeader)
        {
            List<string> allLines = new List<string>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }
            return allLines;
        }
    }
}
