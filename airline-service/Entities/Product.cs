using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace airline_service.Entities
{
    [Table("product")]
    public partial class Product
    {
        public Product()
        {
        }

        [Column("id")] public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Column("description")]
        [StringLength(5000)]
        public string Description { get; set; }

        [Required]
        [Column("visibility")]
        [StringLength(10)]
        public string Visibility { get; set; }

        [Column("price", TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Column("price_currency")]
        [StringLength(3)]
        public string PriceCurrency { get; set; }

        [Column("stock")] public int Stock { get; set; }
        [Column("order_quantity")] public int? OrderQuantity { get; set; }
    }
}