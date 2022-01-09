using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentHub.Server.Data;
using RentHub.Shared;

[Route("api/[controller]")]
[ApiController]
public class RoommateController : ControllerBase
{
    private readonly ApplicationDBContext _context;

    public RoommateController(ApplicationDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var roommates = await _context.Roommates.ToListAsync();
        return Ok(roommates);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var roommate = await _context.Roommates.FirstOrDefaultAsync(a => a.Id == id);
        return Ok(roommate);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Roommate roommate)
    {
        _context.Add(roommate);
        await _context.SaveChangesAsync();
        return Ok(roommate.Id);
    }

    [HttpPut]
    public async Task<IActionResult> Put(Roommate roommate)
    {
        _context.Entry(roommate).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var roommate = new Roommate { Id = id };
        _context.Remove(roommate);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}