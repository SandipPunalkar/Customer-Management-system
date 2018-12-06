using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repository
{

    public class CustomerRepositry
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "stevejobs@gmail.com";
                customer.FirstName = "Steve";
                customer.LastName = "Jobs";
            }
            return customer;
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
