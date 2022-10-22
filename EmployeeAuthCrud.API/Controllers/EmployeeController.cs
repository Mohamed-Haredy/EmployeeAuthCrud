using EmployeeAuthCrud.Domain.Entities;
using EmployeeAuthCrud.Domain;
using Microsoft.AspNetCore.Mvc; 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeAuthCrud.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IUnitOfWork unitOfWork;

    public EmployeeController(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    // GET: api/<ItemController>
    [HttpGet]
    
    public async Task<IActionResult> GetAsync()
    {
        var Employee = await unitOfWork.EmployeeRepository.GetAllAsync();
        return Ok(Employee);
    }
    // GET api/<ItemController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var Employee = await unitOfWork.EmployeeRepository.GetAsync(w => w.EmployeeId == id);
        if (Employee == null) NoContent();
        return Ok(Employee);
    }


    // POST api/<ItemController>
    [HttpPost]
    public async Task PostAsync([FromBody] Employee value)
    {
        if (ModelState.IsValid)
        {
            await unitOfWork.EmployeeRepository.AddAsync(value);
            await unitOfWork.SaveChangesAsync();
        }
    }

    // PUT api/<ItemController>/5
    [HttpPut("{id}")]
     
    public async Task PutAsync(int id, [FromBody] Employee value)
    {
        await unitOfWork.EmployeeRepository.UpdateAsync(value);
        await unitOfWork.SaveChangesAsync();
    }

    // DELETE api/<ItemController>/5
    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        var value = await unitOfWork.EmployeeRepository.GetAsync(w => w.EmployeeId == id);
        await unitOfWork.EmployeeRepository.DeleteAsync(value);
        await unitOfWork.SaveChangesAsync();
    }
}
