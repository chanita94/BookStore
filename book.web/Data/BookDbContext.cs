using book.web.Models;
using Microsoft.EntityFrameworkCore;

namespace book.web.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) 
        { 
        
        
        }

        public DbSet<Category> Categories { get; set; }


    }
}
