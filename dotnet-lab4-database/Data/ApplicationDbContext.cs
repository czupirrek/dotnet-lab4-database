using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dotnet_lab4_database.Components;

namespace dotnet_lab4_database.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{

public DbSet<dotnet_lab4_database.Components.DbAlbum> DbAlbum { get; set; } = default!;
}
