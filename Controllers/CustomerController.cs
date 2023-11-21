using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace storageApi;

[ApiController]
[Route("api/[controller]")]
public class CustomerController(ICustomerRepository customerRepository, ILogger<CustomerController> logger, IMapper mapper) : ControllerBase
{
    private readonly ICustomerRepository _customerRepository = customerRepository;
    private readonly ILogger<CustomerController> _logger = logger;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    public async Task<ActionResult<List<CustomerDto>>> GetCustomers()
    {
        try
        {
            var customers = _mapper.Map<List<CustomerDto>>(await _customerRepository.GetCustomers());
            return Ok(customers);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error ocurred");
            return StatusCode(500, "Internal Error Server");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CustomerDto>> GetCustomer(int id)
    {
        try
        {
            var customer = _mapper.Map<CustomerDto>(await _customerRepository.GetCustomer(id));
            if (customer == null)
            {
                return NotFound($"Customer with {id} IDs not found");
            }
            return Ok(customer);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error ocurred");
            return StatusCode(500, "Internal Error Server");
        }
    }

    [HttpPost]
    public async Task<ActionResult<Customer>> CreateCustomer(CustomerDto customerDto)
    {
        try
        {
            var customerMapped = _mapper.Map<Customer>(customerDto);
            bool isCreated = await _customerRepository.CreateCustomer(customerMapped);
            if (!isCreated)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(customerMapped);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error ocurred");
            return StatusCode(500, "Internal Error Server");
        }
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> DeleteCustomer(int id)
    {
        try
        {
            var customer = await _customerRepository.GetCustomer(id);
            if (customer == null)
            {
                return NotFound($"Customer not found");
            }
            bool isDeleted = await _customerRepository.RemoveCustomer(customer);
            if (!isDeleted)
            {
                return BadRequest(ModelState);
            }
            return Ok(isDeleted);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error ocurred");
            return StatusCode(500, "Internal Error Server");
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<CustomerDto>> UpdateCustomer(int id, CustomerDto customerDto)
    {
        try
        {
            var customerMapped = _mapper.Map<Customer>(await _customerRepository.GetCustomer(id));
            if (customerMapped == null)
            {
                return NotFound($"Customer not found");
            }
            bool isUpdated = await _customerRepository.UpdateCustomer(customerMapped);
            if (!isUpdated) return BadRequest(ModelState);
            return Ok(isUpdated);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error ocurred");
            return StatusCode(500, "Internal Error Server");
        }
    }
}
