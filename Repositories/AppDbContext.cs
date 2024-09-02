using Iguaman.Models.Pengguna;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Iguaman.Repositories
{
    public class AppDbContext:IdentityDbContext<Pengguna, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options)
            : base(options) 
        { 
        
        }


    }
}
