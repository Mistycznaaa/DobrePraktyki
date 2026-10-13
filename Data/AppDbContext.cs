using Microsoft.EntityFrameworkCore;
using HormoneHarmony.Models;

namespace HormoneHarmony.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Recipe> Recipes { get; set; }
}