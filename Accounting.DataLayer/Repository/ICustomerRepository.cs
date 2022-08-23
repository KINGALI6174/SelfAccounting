using Accounting.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCustomerByFilter(string parameter);
        String GetCustomerNameById(int customerId);
        List<ListCustomer> GetNameCustomer(string parameter = "");
        //int GetCustomerIdByName(string name);
        Customers GetCustomerbyId(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
    }
}
