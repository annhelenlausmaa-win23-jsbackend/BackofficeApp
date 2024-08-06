using BackofficeApp.Components.Pages;
using BackofficeApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace BackofficeApp.Services;

public class UserService(UserManager<ApplicationUser> userManager)
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<List<ApplicationUser>> GetAllUsersAsync()
    {
        try
        {
            List<ApplicationUser> users = await _userManager.Users.ToListAsync();
            return users;
        }
        catch
        {
            return null!;
        }
    }

    public async Task UpdateUserAsync(ApplicationUser user)
    {
        try
        {

        }
        catch
        {

        }
    }

    public async Task<bool> DeleteUserAsync(ApplicationUser user)
    {
        try
        {
            IdentityResult result = await _userManager.DeleteAsync(user);
            if (result.Succeeded) 
                return true;
            else
                return false;
        }
        catch
        {
            return false;
        }
    }
}
