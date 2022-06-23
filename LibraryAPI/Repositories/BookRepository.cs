using LibraryAPI.Data;
using LibraryAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public async Task<Book> CreateAsync(Book book)
        {
          await  _context.Books.AddAsync(book);
          await _context.SaveChangesAsync();
          return book;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _context.Books.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var removedEntity = await _context.Books.FindAsync(id);
            _context.Books.Remove(removedEntity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            var unchangedEntity = await _context.Books.FindAsync(book.Id);
            _context.Entry(unchangedEntity).CurrentValues.SetValues(book);
            await _context.SaveChangesAsync();
        }
    }
}
