using System;
using static System.Console;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SharpPad;

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


        static async Task Main(string[] args)
        {
            QueryingCategories();
        }

        static async Task QueryingCategories()
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
                await cats.Dump();
            }
        }
    }
}
