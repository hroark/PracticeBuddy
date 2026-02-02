using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PracticeBuddy.Data
{
    /// <summary>
    /// Provides an application user class that extends the IdentityUser class.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Identity.IdentityUser" />
    public class ApplicationUser(string userName, string password, string passwordVerification) : IdentityUser(userName)
    {
        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public required string Password { get; set; } = password;

        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        [Compare(nameof(Password), ErrorMessage = "The passwords do not match.")]
        public required string PasswordVerification { get; set; } = passwordVerification;
    }
}