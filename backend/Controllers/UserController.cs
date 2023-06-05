using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IdentityDbContext<ApplicationUser> _dbContext;

    public UserController(IdentityDbContext<ApplicationUser> dbContext)
    {
        _dbContext = dbContext;
    }


    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> PostUser([FromBody] UserDTO userDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var user = new ApplicationUser
        {
            Name = userDTO.Name
        };

        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        return Ok(user);
    }
}

