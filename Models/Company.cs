using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDilvery_MVC.Models
{
    public class Company
    {

        public int Id { get; set; }
        [Required]
        public string Name  { get; set; }
        public string Address { get; set; }




    }
}
