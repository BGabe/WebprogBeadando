using HouseHoldApplianceStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseHoldApplianceStore.Repository
{
    public class GenericUnitOfWork: IDisposable
    {

        private dbStoreEntities DBEntity = new dbStoreEntities();
        public IRepository<Tbl_EntityType> GetRepositoryInstance<Tbl_EntityType>() where Tbl_EntityType : class
        {
            return new GenericRepository<Tbl_EntityType>(DBEntity);
        }

        public void SaveChanges()
        {
            DBEntity.SaveChanges();
        }

        protected virtual void Dispose(bool disposeing)
        {
            if (!this.disposed)
            {
                if (disposeing)
                {
                    DBEntity.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
    }
}