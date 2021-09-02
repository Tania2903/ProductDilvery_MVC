using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDilvery_MVC.Models
{
    public class Product
    {

        public int Id { get; set; } // player id 
        [Required]
        public string Name { get; set; } // player name 
        public string Description { get; set; } // country from wher player belongs 

        public decimal Price_per_Item { get; set; } // which game player played for thier country 

        public int Qty { get; set; } // which game player played for thier country 
        public decimal Total_Price { get; set; } 

    }
}
