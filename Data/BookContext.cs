using CRUD_ASP.NET_CORE.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ASP.NET_CORE.Data
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base(options) { 
        }

        public DbSet<Book> Books => Set<Book>(); // tên bảng lấy từ đây
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Category> Categories => Set<Category>();

    }
}
