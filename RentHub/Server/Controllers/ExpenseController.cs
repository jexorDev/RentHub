using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentHub.Server.Data;
using RentHub.Shared.Expenses;

[Route("api/[controller]")]
[ApiController]
public class ExpenseController : ControllerBase
{
    private readonly ApplicationDBContext _context;

    public ExpenseController(ApplicationDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var expenses = await _context.Expenses.ToListAsync();
        return Ok(expenses);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var dev = await _context.Expenses.FirstOrDefaultAsync(a => a.Id == id);
        return Ok(dev);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Expense expense)
    {
        _context.Add(expense);
        await _context.SaveChangesAsync();
        return Ok(expense.Id);
    }

    [HttpPut]
    public async Task<IActionResult> Put(Expense expense)
    {
        _context.Entry(expense).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var roommate = new Expense { Id = id };
        _context.Remove(roommate);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}