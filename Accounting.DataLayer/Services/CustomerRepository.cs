using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        AccountingEntities db = new AccountingEntities();
        public bool DeleteCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerbyId(int customerId)
        {
            throw new NotImplementedException();
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Svae()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }
    }
}
