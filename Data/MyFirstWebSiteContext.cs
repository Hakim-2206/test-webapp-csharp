using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstWebSite.Models;

namespace MyFirstWebSite.Data
{
    public class MyFirstWebSiteContext : DbContext
    {
        public MyFirstWebSiteContext (DbContextOptions<MyFirstWebSiteContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstWebSite.Models.Customer> Customer { get; set; } = default!;
    }
}
