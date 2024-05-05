using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using zad2.Data;

namespace zad2.Data {
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options) {
        public DbSet<zad2.Data.Game> Game { get; set; } = default!;
    }
}
