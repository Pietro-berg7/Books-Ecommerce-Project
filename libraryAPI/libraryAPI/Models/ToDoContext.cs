using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option)
            : base(option)
        { }

        public DbSet<Product> todoProducts { get; set; }
    }
}
