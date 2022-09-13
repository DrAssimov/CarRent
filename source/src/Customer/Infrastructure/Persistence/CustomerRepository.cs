namespace CarRent.Customer.Infrastructure.Persistence
{
    using System;
    using System.Collections.Generic;
    using CarRent.Customer.Domain;
    using CarRent.Customer.Infrastructure.Persistence;
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _customerContext;

        public CustomerRepository(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public void Add(Customer customer)
        {
            _customerContext.Customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            _customerContext.Customers.Update(customer);
        }

        public void Remove(Customer customer)
        {
            _customerContext.Customers.Remove(customer);
        }

        public Customer GetById(Guid id)
        {
            var customer = _customerContext.Customers.Find(id);
            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerContext.Customers.ToList();
        }
    }
}

