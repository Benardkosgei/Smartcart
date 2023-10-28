using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartCart.Models;

namespace SmartCart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SmartCart.Models.Category>? Category { get; set; }
        public DbSet<SmartCart.Models.Item>? Item { get; set; }
        public DbSet<SmartCart.Models.Order>? Order { get; set; }
        public DbSet<SmartCart.Models.User>? User { get; set; }
    }
}