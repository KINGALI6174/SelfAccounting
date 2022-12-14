using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.ViewModel.Customer;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private AccountingEntities db;
        public CustomerRepository(AccountingEntities contex)
        {
            db = contex;
        }
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerbyId(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerbyId(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public IEnumerable<Customers> GetCustomerByFilter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
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


        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ListCustomer> GetNameCustomer(string parameter = "")
        {
            if (parameter == "")
            {
                return db.Customers.Select(c => new ListCustomer()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName,
                }).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(parameter)).Select(c => new ListCustomer()
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName,
            }).ToList();
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).FullName;
        }

        //public bool AddUser(Login login)
        //{
        //    try
        //    {
        //        db.Login.Add(login);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        // Because the name and surname are not unique This method cannot be used
        //public int GetCustomerIdByName(string name)
        //{
        //    return db.Customers.First(c => c.FullName == name).CustomerID;
        //}
    }
}
