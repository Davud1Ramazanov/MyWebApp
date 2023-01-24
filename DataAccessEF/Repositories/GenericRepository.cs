using DataAccessEF.Data;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private static ProdDbContext _prodDbContext;

        public GenericRepository(ProdDbContext prodDbContext)
        {
            _prodDbContext = prodDbContext;
        }

        public void AddProd(T e)
        {
            _prodDbContext.Set<T>().Add(e);
        }

        public void DeleteProd(T e)
        {
            _prodDbContext.Set<T>().Remove(e);
        }

        public void EditProd(T e)
        {
            Microsoft.EntityFrameworkCore.EntityState s = _prodDbContext.Set<T>().Entry(e).State ;
        }

        public IEnumerable<T> GetAll() => _prodDbContext.Set<T>().ToList();
    }
}
