using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CartApp.DataAccess
{
    /// <summary>
    /// Base Interface for the Entity Repositories.
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Gell All availabel records from the database.
        /// </summary>
        /// <param name="filter">Filter Query by this Parameter</param>
        /// <param name="orderBy">Order Query by this Parameter</param>
        /// <param name="includeProperties">Include All these properties in the result</param>
        /// <returns></returns>
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, string includeProperties);

        /// <summary>
        /// Adds the record to the database.
        /// </summary>
        /// <param name="entityToAdd">Record to be added to the databse.</param>
        void Add(T entity);

        /// <summary>
        /// Removes the record from the database.
        /// </summary>
        /// <param name="entityToDelete">Record to be removed from the database</param>
        void Delete(T entity);

        /// <summary>
        /// Updates a given record in the database.
        /// </summary>
        /// <param name="entityToUpdate">record to be updated in the databse.</param>
        void Update(T entity);

        /// <summary>
        /// Find a record from the the database.
        /// </summary>
        /// <param name="entityId">Id of the record to be searched.</param>
        /// <returns></returns>
        T FindById(int Id);
    }
}
