using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BackofficeApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null!;
        public string? Biography { get; set; }
        public string? ProfileImage { get; set; } = "avatar.jpg";
        public string? AddressId { get; set; }
        public UserAddress? Address { get; set; }
    }

    public class UserAddress
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
    }

}
