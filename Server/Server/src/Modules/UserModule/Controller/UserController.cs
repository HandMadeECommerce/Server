using Microsoft.AspNetCore.Mvc;
using Server.src.Core.Context;
using Server.src.Modules.UserModule.Model.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.src.Modules.UserModule.Controller;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }
    // GET: api/<UserController>
    [HttpGet]
    public IEnumerable<User> Get()
    {
        return _context.Users;
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public User? Get(Guid id) => _context.Users.Find(id);

    // POST api/<UserController>
    [HttpPost]
    public IActionResult Post([FromBody] User user)
    {
        if (user == null) { return BadRequest(); }

        _context.Users.Add(user);
        _context.SaveChanges();

        return Ok();
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        var result = _context.Users.Find(id);

        if (result is null)
        {
            return;
        }

        _context.Users.Remove(result);
        _context.SaveChanges();
    }
}
