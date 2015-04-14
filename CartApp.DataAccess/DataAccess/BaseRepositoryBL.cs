using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CartApp.DataLayer;
using System.Linq.Expressions;

namespace CartApp.DataAccess.DataAccess
{
    /// <summary>
    /// Base Class for the Entity Repositories.
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    public abstract class BaseRepositoryBL<T> : IRepository<T> where T : class
    {
        internal DbSet<T> dbset;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initilizing the unit of work/context.
        /// </summary>
        /// <param name="unitOfWork">unit of work/ context</param>
        public BaseRepositoryBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            dbset = _unitOfWork.Context.Set<T>();
        }

        /// <summary>
        /// Gell All availabel records from the database.
        /// </summary>
        /// <param name="filter">Filter Query by this Parameter</param>
        /// <param name="orderBy">Order Query by this Parameter</param>
        /// <param name="includeProperties">Include All these properties in the result</param>
        /// <returns></returns>
        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = dbset;

            // Filter by Condition
            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Including the provided columns.
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            // Order by clause.
            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        /// <summary>
        /// Adds the record to the database.
        /// </summary>
        /// <param name="entityToAdd">Record to be added to the databse.</param>
        public void Add(T entityToAdd)
        {
            dbset.Add(entityToAdd);
        }

        /// <summary>
        /// Removes the record from the database.
        /// </summary>
        /// <param name="entityToDelete">Record to be removed from the database</param>
        public void Delete(T entityToDelete)
        {
            if (_unitOfWork.Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbset.Attach(entityToDelete);
            }
            dbset.Remove(entityToDelete);
        }

        /// <summary>
        /// Updates a given record in the database.
        /// </summary>
        /// <param name="entityToUpdate">record to be updated in the databse.</param>
        public void Update(T entityToUpdate)
        {
            dbset.Attach(entityToUpdate);
            _unitOfWork.Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        /// <summary>
        /// Find a record from the the database.
        /// </summary>
        /// <param name="entityId">Id of the record to be searched.</param>
        /// <returns></returns>
        public T FindById(int entityId)
        {
            return dbset.Find(entityId);
        }
    }
}
