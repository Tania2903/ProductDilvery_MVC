using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDilvery_MVC.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Client Client { get; set; }
        public int Clientid { get; set; }

        public Company Company { get; set; }
        public int Companyid { get; set; }
        public Product Product { get; set; }
        public int Productid { get; set; }

  
       
         public DateTime order { get; set; }
        public DateTime Expected { get; set; }





    }
}
