using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public UserController(AppDbContext dbContext)
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

        var user = new User
        {
            Name = userDTO.Name
        };

        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        return Ok(user);
    }
}

