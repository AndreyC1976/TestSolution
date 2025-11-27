using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksEF.MyClasses.Books
{
    public class AuthorServices
    {
        private readonly BookContext _context;

        public AuthorServices(BookContext context)
        {
            _context = context;
        }

        // Получаем всех авторов (таблица)
        public async Task<AuthorEntity> GetAuthorByIdAsync(int id)
        {
            return await _context.Authors.FindAsync(id);
        }

        public async Task<List<AuthorEntity>> GetAllAuthorsAsync()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<AuthorEntity> AddAuthorAsync(AuthorEntity author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return author;
        }
    }
}
