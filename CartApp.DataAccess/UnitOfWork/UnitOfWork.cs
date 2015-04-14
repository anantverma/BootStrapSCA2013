using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartApp.DataAccess;
using CartApp.DataLayer;
using System.Transactions;
using System.Data.Entity;

namespace CartApp.DataAccess
{
    /// <summary>
    /// Unit Of Work Class
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private ShoppingCartDbEntities context = new ShoppingCartDbEntities();
        private bool disposed = false;
        private TransactionScope _transaction;

        /// <summary>
        /// Disposes the Context.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Disposes the current DB Context
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Commits the transaction.
        /// </summary>
        public void Commit()
        {
            _transaction.Complete();
            context.SaveChanges();
        }

        /// <summary>
        /// Returns the current Db Context
        /// </summary>
        public DbContext Context
        {
            get 
            {
                return context;
            }
        }

        /// <summary>
        /// Begins the transaction
        /// </summary>
        public void StartTransaction()
        {
            _transaction = new TransactionScope();
        }
    }
}