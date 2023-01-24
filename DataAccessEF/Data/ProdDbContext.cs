using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Data
{
    public class ProdDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public ProdDbContext(DbContextOptions dbContext) : base(dbContext) { }
    }
}
