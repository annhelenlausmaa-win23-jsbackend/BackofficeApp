namespace BackofficeApp.Models;

public class UpdateUserFormModel
{   
    public string? FirstName { get; set; } = null!;
    public string? LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public string? Biography { get; set; }
    public string? ProfileImage { get; set; } = "avatar.jpg";
}


