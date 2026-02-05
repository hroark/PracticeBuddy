using PracticeBuddy.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticeBuddy.Models;

namespace PracticeBuddy.Data;

public class UserDbContext(DbContextOptions<UserDbContext> options) : IdentityDbContext<UserLogin>(options)
{
}