using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketMgmt.CoreBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Category field is required.")]
        public int? CategoryId { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public double? Price { get; set; }
    }
}
