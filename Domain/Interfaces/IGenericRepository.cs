using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public void AddProd(T e);
        public void EditProd(T e);
        public void DeleteProd(T e);
        public IEnumerable<T> GetAll();
    }
}
