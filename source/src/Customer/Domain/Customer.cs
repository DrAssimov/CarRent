namespace CarRent.Customer.Domain
{
    using CarRent.Customer.Api.V1;
    using CarRent.Common.Domain;
    public class Customer : Entity, IAggregateRoot
    {
        private CustomerResponseDto customerResponseDto;

        public Customer (CustomerResponseDto customerResponseDto)
        {
            this.customerResponseDto = customerResponseDto;
        }
        public string CustomerNumber { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public string Country { get; set; }
    }
}
