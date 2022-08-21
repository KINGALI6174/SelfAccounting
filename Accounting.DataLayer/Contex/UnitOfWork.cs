using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Contex
{
    public class UnitOfWork : IDisposable
    {
        AccountingEntities db = new AccountingEntities();
        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }
        private GenericRepository<Accounting> _accountingRepository;
        public GenericRepository<Accounting> AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<Accounting>(db);
                }
                return _accountingRepository;
            }
        }

        public void save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
