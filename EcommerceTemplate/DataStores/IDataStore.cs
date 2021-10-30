using EcommerceTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceTemplate.DataStores
{
    public interface IDataStore<T> where T : Entity
    {
        Task<T> AddAsync(T item);
        Task<bool> UpdateAsync(T item);
        Task<bool> DeleteAsync(string id);
        Task<bool> DeleteAllAsync();
        Task<T> GetAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IQueryable<T>> GetByAsync(Func<T, bool> predicate);
        Task<bool> IsExistAsync(Func<T, bool> predicate);
    }
}
