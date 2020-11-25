using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WorkingWithEFcore
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength (40)]
        public string ProductName { get; set; }

        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; }

        [Column("UnitsInStock")]
        public short? Stock { get; set; }

        public bool Discontinued { get; set; }

        public int CategoryID { get; set; }
        // Lazy Loading
        // Eager Loading
        public virtual Category Category { get; set; }

    }
}