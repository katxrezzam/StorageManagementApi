using Microsoft.AspNetCore.Mvc;

namespace storageApi;

[ApiController]
[Route("api/[controller]")]
public class CustomerController(ICustomerRepository customerRepository) : ControllerBase
{
    private readonly ICustomerRepository _customerRepository = customerRepository;

    [HttpGet]
    public async Task<ActionResult<List<Customer>>> GetCustomers()
    {
        try
        {
            var customers = await _customerRepository.GetCustomers();
            return Ok(customers);
        }
        catch (Exception)
        {
            throw;
        }

    }
}
