using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.DataContext;
using WindowsForms.Interfaces;

namespace WindowsForms.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        public async Task<T?> AddAsync(T? entity)
        {
            using (CineContext cine = new CineContext())
            {

            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>?> GetAllAsync(string? filtro)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T? entity)
        {
            throw new NotImplementedException();
        }
    }
}
