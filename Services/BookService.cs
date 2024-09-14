using CRUD_ASP.NET_CORE.Data;
using CRUD_ASP.NET_CORE.Models;

namespace CRUD_ASP.NET_CORE.Services
{
    public class BookService
    {
        List<Book> Books { get; }
        //private readonly BookContext _bookContext;
        //static int nextId = 3;

        // BookService(BookContext bookContext)
        //{
        //    this._bookContext = bookContext;
        //    Books = new List<Book> {
        //        new Book { Id = Guid.NewGuid(),Title="40 vạn lợn",Image="1.png",TheLoaiId=Guid.NewGuid()},
        //        new Book { Id = Guid.NewGuid(),Title="50 vạn lợn",Image="2.png",TheLoaiId=Guid.NewGuid()},
        //        new Book { Id = Guid.NewGuid(),Title="60 vạn lợn",Image="3.png",TheLoaiId=Guid.NewGuid()}
        //    };
        //}
        BookService() { }
        //public IEnumerable<Book> GetAll()
        //{
        //  return _bookContext.Books.ToList();
        //}

        //public static Book? Get(Guid id) => Books.FirstOrDefault(b => b.Id == id);


        //public static void Add(Book book)
        //{
        //    Books.Add(book);
        //}

        //public static void Delete(Guid id)
        //{
        //    var book = Get(id);
        //    if (book == null) return;

        //    Books.Remove(book);
        //}

        //public static void Update(Guid id, Book book)
        //{
        //    int index = Books.FindIndex(b => b.Id == id);
        //    if (index == -1) return;
        //    Books[index] = book;
        //}
    }
}
