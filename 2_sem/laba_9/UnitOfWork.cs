using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_9
{
    internal class UnitOfWork
    {
        private UserContext db = new UserContext();
        private UserRepositoriy repUs;

        public UserRepositoriy Users
        {
            get
            {
                if (repUs == null)
                    repUs = new UserRepositoriy(db);
                return repUs;
            }

        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
