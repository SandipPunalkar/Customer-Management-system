using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repository
{

    public class CustomerRepositry
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepositry()
        {
            addressRepository = new AddressRepository();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.
                RetrieveByCustomerId(customerId).ToList();

            if (customerId == 1)
            {
                customer.EmailAddress = "stevejobs@gmail.com";
                customer.FirstName = "Steve";
                customer.LastName = "Jobs";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
                {
                    // Call an Insert Stored Procedure

                }
                else
                {
                    // Call an Update Stored Procedure
                }
            }
            return success;
        }

    }
}
