using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Base class that performs basic CRUD operations.
    /// </summary>
    /// <typeparam name="T">Class derived from entity</typeparam>
    public abstract class BaseDataStore<T> where T : Entity
    {
        protected abstract IList<T> items { get; }

        /// <summary>
        /// Add the entity
        /// </summary>
        /// <param name="item">Entity object</param>
        /// <returns>Added object</returns>
        public async Task<T> AddAsync(T item)
        {
            items.Add(item);

            return await Task.FromResult(item);
        }

        /// <summary>
        /// Update the entity
        /// </summary>
        /// <param name="item">Entity object</param>
        /// <returns>Result of operation</returns>
        public async Task<bool> UpdateAsync(T item)
        {
            var oldItem = items.Where((T arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Delete entity by id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Result of operation</returns>
        public async Task<bool> DeleteAsync(string id)
        {
            var oldItem = items.Where((T arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Delete all entities
        /// </summary>
        /// <returns>Result of operation</returns>
        public async Task<bool> DeleteAllAsync()
        {
            items.Clear();

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Get Entity by id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Entity by Id</returns>
        public async Task<T> GetAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        /// <summary>
        /// Get all Entities.
        /// </summary>
        /// <returns>List of all result</returns>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.FromResult(items);
        }

        /// <summary>
        /// Get a result by parametrized query.
        /// </summary>
        /// <param name="predicate">Query with specific parameters</param>
        /// <returns>List of filtered result</returns>
        public async Task<IQueryable<T>> GetByAsync(Func<T, bool> predicate)
        {
            var result = items.Where(predicate).AsQueryable();

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Is there at least one entity?
        /// </summary>
        /// <param name="predicate">Query with specific parameters</param>
        /// <returns>True if there is at least one entity.</returns>
        public async Task<bool> IsExistAsync(Func<T, bool> predicate)
        {
            var result = items.Any(predicate);

            return await Task.FromResult(result);
        }
    }
}
