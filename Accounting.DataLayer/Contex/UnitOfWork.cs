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
                if( _customerRepository == null)
                {
                    _customerRepository=new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
