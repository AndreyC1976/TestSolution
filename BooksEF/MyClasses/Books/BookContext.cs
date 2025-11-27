using Microsoft.EntityFrameworkCore;

namespace BooksEF.MyClasses.Books
{
    public class BookContext : DbContext
    {
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        
        // Конструктор без свойств
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

    }
}
