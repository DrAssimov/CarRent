namespace CarRent.Customer.Domain
{
    using CarRent.Common.Domain;
    using CarRent.Customer.Domain;
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetAll();
    }
}
