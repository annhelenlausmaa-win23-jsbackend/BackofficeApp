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

    public async Task<ApplicationUser> GetUserAsync(ApplicationUser selectedUser)
    {
        try
        {
            ApplicationUser? user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == selectedUser.Id);
            if (user != null) 
                return user;
            else
                return null!;
        }
        catch
        {
            return null!;
        }
    }

    public async Task<bool> UpdateUserAsync(ApplicationUser updatedUser)
    {
        try
        {
            IdentityResult result = await _userManager.UpdateAsync(updatedUser);
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
