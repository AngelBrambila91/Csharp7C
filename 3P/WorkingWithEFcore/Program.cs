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
            //QueryingProducts();
            //QueryingWithLike();

            // Loading patterns
             // Lazy Loading
             // Eager Loading
             // Explicit Loading

             if(AddProduct(7, "Helado Tempura", 600M))
             {
                 WriteLine("Add product successful");
             }

             if(IncreaseProductPrice("Helado", 20M))
             {
                 WriteLine("Update Product price successful");
             }
             
             int deleted = DeleteProducts("Helado");
             WriteLine($"{deleted}  product(s) where deleted");

             ListProducts();
        }

        #region Querying Categories
            
        static void QueryingCategories()
        {
            using (var db = new Northwind())
            {
                //var loggerFactory = db.GetService<ILoggerFactory>();
                //loggerFactory.AddProvider(new ConsoleLoggerProvider());
                WriteLine("Categories and how many product they have");
                // a query to get all the categories and their related products
                IQueryable<Category> cats ; //db.Categories.Include(c => c.Products);

                db.ChangeTracker.LazyLoadingEnabled = false;
                Write("Enable eager loading? (Y / N) : ");
                bool eagerloading = ReadKey().Key == ConsoleKey.Y;
                bool explicitloading = false;
                WriteLine();

                if(eagerloading)
                {
                    cats = db.Categories.Include(c => c.Products);
                }
                else
                {
                    cats = db.Categories;
                    Write("Enable Explicit loading? (Y / N) : ");
                    explicitloading = ReadKey().Key == ConsoleKey.Y;
                    WriteLine();
                }

                
                foreach(Category c in cats)
                {
                if(explicitloading)
                {
                    Write ($"Explicitly load products for {c.CategoryName}? (Y / N) : ");
                    bool explicitloading2 = ReadKey().Key == ConsoleKey.Y;
                    WriteLine();
                    if(explicitloading2)
                    {
                        var products = db.Entry(c).Collection(c2 => c2.Products);
                        if(!products.IsLoaded) products.Load();
                    }
                }
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products");
                }
            }
        }
        #endregion

        #region QueryingProducts
            
        static void QueryingProducts()
        {
            using (var db = new Northwind())
            {
                //var loggerFactory = db.GetService<ILoggerFactory>();
                //loggerFactory.AddProvider(new ConsoleLoggerProvider());
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
        #endregion

        #region Querying With Like
            
        static void QueryingWithLike() 
        {
            using (var db = new Northwind())
            {
                //var loggerFactory = db.GetService<ILoggerFactory>();
               //loggerFactory.AddProvider(new ConsoleLoggerProvider());
                Write("Enter part of a product name : ");
                string input = ReadLine();
                IQueryable<Product> prods = db.Products
                .Where(p => EF.Functions.Like(p.ProductName, $"%{input}%"));

                foreach (Product item in prods)
                {
                    WriteLine($"{item.ProductName} has {item.Stock} units in stock. Discontinued? {item.Discontinued}");
                }
            }
        }
        #endregion

        #region Insert Into    
        static bool AddProduct(int categoryID, string productName, decimal? price)
        {
            using (var db = new Northwind())
            {
                var newProduct = new Product
                {
                    CategoryID = categoryID,
                    ProductName = productName,
                    Cost = price
                };

                db.Products.Add(newProduct);

                //save changes to DB
                int affected = db.SaveChanges();
                return (affected == 1);
            }
        }
        #endregion

        #region Get All products
            
        static void ListProducts()
        {
            using (var db = new Northwind())
            {
                WriteLine("{0, -3} {1, -35} {2, 8} {3, 5} {4}",
                "ID", "Product Name", "Cost", "Stock", "Disc.");

                foreach (var item in db.Products.OrderByDescending(p => p.Cost))
                {
                    WriteLine($"{item.ProductID : 000} {item.ProductName, -35} {item.Cost:#,##0.00} {item.Stock, 5} {item.Discontinued}");
                }
            }
        }
        #endregion
    
        #region Update price
        static bool IncreaseProductPrice (string name, decimal amount)
        {
            using (var db = new Northwind())
            {
                // get products whose name stats with name
                Product updateProduct = db.Products.First(p => p.ProductName.StartsWith(name));

                updateProduct.Cost = amount;

                int affected = db.SaveChanges();
                return (affected == 1);
            }

        }
        #endregion

        #region Delete a Product
            static int DeleteProducts(string name)
            {
            using (var db = new Northwind())
                {
                IEnumerable<Product> prods = db.Products.Where(p=> p.ProductName.StartsWith(name));
                db.Products.RemoveRange(prods);

                int affected = db.SaveChanges();
                return affected;
                }
            }
        #endregion
    }
}
