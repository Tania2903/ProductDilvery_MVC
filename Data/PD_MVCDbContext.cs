using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductDilvery_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDilvery_MVC.Data
{
    public class PD_MVCDbContext : DbContext
    {

        public DbSet<Client> Client { get; set; }
        public DbSet<Company> Comapny { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public PD_MVCDbContext(DbContextOptions<PD_MVCDbContext> options)
            : base(options)
        {
        }

        public PD_MVCDbContext()

        {


        }

    }

   

}
