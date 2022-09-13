namespace CarRent.Customer.Api.V1
{
    using CarRent.Customer.Domain;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/v1/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository repository)
        {
            _customerRepository = repository;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
            var customer = _customerRepository.GetAll();
            var customerDtos = customer.Select(c => new CustomerResponseDto(c));
            return Ok(customerDtos);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var customer = _customerRepository.GetById(new Guid(id));
            return Ok(customer);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] CustomerResponseDto customerResponseDto)
        {
            _customerRepository.Add(new Customer(customerResponseDto));
            return Ok();
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
