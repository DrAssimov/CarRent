namespace CarRent.Customer.Api.V1
{
    using System.Text.Json.Serialization;
    public class CustomerResponseDto
    {
        [JsonPropertyName("id")]
        [JsonPropertyOrder(100)]
        public string CustomerNumber { get; set; }

        [JsonPropertyName("firstname")]
        [JsonPropertyOrder(200)]
        public string Firstname { get; set; }

        [JsonPropertyName("lastname")]
        [JsonPropertyOrder(300)]
        public string Lastname { get; set; }

        [JsonPropertyName("Street")]
        [JsonPropertyOrder(400)]
        public string Street { get; set; }

        [JsonPropertyName("StreetNumber")]
        [JsonPropertyOrder(500)]
        public int Streetnumber { get; set; }

        [JsonPropertyName("City")]
        [JsonPropertyOrder(600)]
        public string City { get; set; }

        [JsonPropertyName("ZipCode")]
        [JsonPropertyOrder(700)]
        public int ZipCode { get; set; }

        [JsonPropertyName("Country")]
        [JsonPropertyOrder(800)]
        public string Country { get; set; }

        public CustomerResponseDto(Domain.Customer customer)
        {
            CustomerNumber = customer.CustomerNumber;
            Firstname = customer.Firstname;
            Lastname = customer.Lastname;
            Street = customer.Street;
            Streetnumber = customer.StreetNumber;
            City = customer.City;
            ZipCode = customer.ZipCode;
            Country = customer.Country;
        }
    }
}
