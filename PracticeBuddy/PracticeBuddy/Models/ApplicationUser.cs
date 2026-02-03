using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PracticeBuddy.Models
{
    /// <summary>
    /// Provides an application user class that extends the IdentityUser class.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Identity.IdentityUser" />
    public class ApplicationUser(string userName, string password) : IdentityUser(userName)
    {
        [Required]
        [EmailAddress]
        public override string? Email { get; set; } = string.Empty; 

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; } = false;

        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public required string Password { get; set; } = password;

        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        [Compare(nameof(Password), ErrorMessage = "The passwords do not match.")]
        [DataType(DataType.DateTime)]
        public DateTime? LastLogin { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime? CreatedAt { get; set; }
    }
}