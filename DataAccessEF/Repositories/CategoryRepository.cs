using DataAccessEF.Data;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Repositories
{
    public class CategoryRepository<T> : IProductRepository<T> where T : class
    {
        private static ProdDbContext dbContext;

        public CategoryRepository(ProdDbContext prodDb)
        {
            dbContext = prodDb;
        }
        public IEnumerable<T> GetPopular()
        {
            foreach(var item in dbContext.ProductCategories) {
                dbContext.Products.ToList().Where(x => x.CategoryId.Equals(item)).Count();
            }
            return (IEnumerable<T>)dbContext.ProductCategories.ToList()[1];
        }
    }
}
