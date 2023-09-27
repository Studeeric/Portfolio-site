using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string Name { get; set; } = null!;
}


public class UserDTO
{
    [Required]
    public string Name { get; set; } = null!;
}