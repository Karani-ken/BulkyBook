using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        //configuring the application db context
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {                
        }
        //creating a category table in the database using a db set (DbSet)
        public DbSet<Category> Categories { get; set; }

    }
}
