using System;
using System.Collections.Generic;
using System.Text;

namespace HW5.Concrete
{
    class CustomerManager:ICustomerServices
    { public void Add(Customer customer)
        {
            Console.WriteLine("Customer is added" + customer.FirstName + customer.LastName+customer.YearofBirth);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is deleted" + customer.FirstName + customer.LastName + customer.IdentityNumber);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer is updated, new customer is added" + customer.FirstName + customer.LastName + customer.IdentityNumber);
        }
    }

    internal interface ICustomerServices
    {
    }
}
