
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}