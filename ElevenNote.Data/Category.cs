using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string ProductName { get; set; }
        
        [Required]
        public string Occasion { get; set; }

        [Required]
        [Range(0,double.MaxValue, ErrorMessage = "The price must be greater than 0")]
        public double Price { get; set; }
        
        [Required]
        public int StockQuantity { get; set; }

        
        public DateTimeOffset? CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
