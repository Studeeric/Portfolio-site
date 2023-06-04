using System.ComponentModel.DataAnnotations;
public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    // Add more properties as needed
}

public class UserDTO
{
    [Required]
    public string Name {get; set;}
}