using System;
using static System.Console;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SharpPad;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WorkingWithEFcore
{
    class Program
    {
        // Object Oriented Model
        // annotations attributes
        // Fluent API
        // Conventions : 
        // nvarchar == string
        // same name of tables in DB
        // same names of fields in DB
        // GUid , IDENTITY
        /*
        [Required]
        [StringLength (40)]
        public string ProductName {get; set;}

        [Column (TypeName) = "money"]
        public decimal? UnitPrice {get; set;}
        */


        static void Main(string[] args)
        {
            //QueryingCategories();
            QueryingProducts();
        }

        static void QueryingCategories()
        {
            using (var db = new Northwind())
            {
                WriteLine("Categories and how many product they have");
                // a query to get all the categories and their related products
                IQueryable<Category> cats = db.Categories.Include(c => c.Products);
                
                foreach(Category c in cats)
                {
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products");
                }
            }
        }

        static void QueryingProducts()
        {
            using (var db = new Northwind())
            {
                // var loggerFactory = db.GetService<ILoggerFactory>();
                // loggerFactory.AddProvider(new ConsoleLoggerProvider());
                WriteLine("Products that cost more than a price.");
                string input;
                decimal price;
                do
                {
                    Write("Enter a product price : ");
                    input = ReadLine();
                } while (!decimal.TryParse(input, out price));

                var prods = db.Products
                .Where(p => p.Cost > price)
                .OrderByDescending (p => p.Cost);

                foreach (Product item in prods)
                {
                    WriteLine($"{item.ProductID} : {item.ProductName} costs {item.Cost: $#,##0.00} and has {item.Stock} in stock.");
                }
            }
        }
    }
}
