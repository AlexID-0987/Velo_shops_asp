using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Velo_shops_asp.Models
{
    public class BakeContext : DbContext
    {
        
        public DbSet<Velobake> Velobakes {get;set;}
        public DbSet<Order> Orders { get; set; }
        public BakeContext(DbContextOptions<BakeContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
