using System.ComponentModel.DataAnnotations;

namespace PracticeBuddy.Models;

/// <summary>
/// Provides an application user class for authentication without Identity.
/// </summary>
public class UserLogin
{
    public UserLogin()
    {
    }

    [Required] [EmailAddress] public string? Email { get; set; }

    [Display(Name = "Remember me?")] public bool RememberMe { get; set; } = false;

    [Required] public required string? Password { get; set; }

    [DataType(DataType.DateTime)] public DateTime? LastLogin { get; set; } = DateTime.Now;

    [DataType(DataType.DateTime)] public DateTime? CreatedAt { get; set; }
}