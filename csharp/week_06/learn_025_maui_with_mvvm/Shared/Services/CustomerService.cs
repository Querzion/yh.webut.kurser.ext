using Shared.Models;
using System.Data;

namespace Shared.Services;

public class CustomerService
{
    private List<Customer> _customers = []; 

    public bool AddCustomerToList(Customer customer)
    {
        if (!string.IsNullOrWhiteSpace(customer.CompanyName))
        {
            _customers.Add(customer);
            return true;
        } 
        return false;
    }

    public IEnumerable<Customer> GetCustomers()
    {
        return _customers;
    }

    public bool RemoveCustomerToList(Customer customer)
    {
        if (!string.IsNullOrWhiteSpace(customer.CompanyName))
        {
            var existingCustomer = _customers.FirstOrDefault(x => x.CompanyName == customer.CompanyName);
            
            if (existingCustomer != null)
            {
                _customers.Remove(existingCustomer);
                return true;
            }
        }
        return false;
    }
}
