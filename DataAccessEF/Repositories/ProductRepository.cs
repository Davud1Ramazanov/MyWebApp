using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Repositories
{
    public class ProductRepository : IGenericRepository<Product>
    {
        public void AddProd(Product e)
        {
            throw new NotImplementedException();
        }

        public void DeleteProd(Product e)
        {
            throw new NotImplementedException();
        }

        public void EditProd(Product e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
