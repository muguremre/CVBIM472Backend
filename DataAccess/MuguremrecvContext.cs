using Microsoft.EntityFrameworkCore;
using muguremreCVBackend.Entities;

namespace muguremreCVBackend.DataAccess
{
    public class MuguremrecvContext : DbContext
    {
        public MuguremrecvContext(DbContextOptions<MuguremrecvContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
