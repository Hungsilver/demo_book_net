using CRUD_ASP.NET_CORE.Data;
using CRUD_ASP.NET_CORE.Dto;
using CRUD_ASP.NET_CORE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ASP.NET_CORE.Controllers
{
    [ApiController]
    [Route("book")]
    public class BookController : ControllerBase
    {
        //private readonly BookService _bookService;
        private readonly BookContext _bookContext;
        public BookController(BookContext bookContext)
        {
            //_bookService = bookService;
            _bookContext = bookContext;
        }
        //get all 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetAll()
        {
            return await _bookContext.Books.ToArrayAsync();
        }

        //getOne
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(Guid id)
        {
            var book = await _bookContext.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Add(BookDTO bookDTO)
        {
            List<Author> ?authors = null;
            var category = await _bookContext.Categories.FindAsync(bookDTO.Category);
            if(bookDTO.Authors != null && bookDTO.Authors.Count == 0)
            {
             authors = await _bookContext.Authors.Where(a => bookDTO.Authors.Contains(a.Id)).ToListAsync();
            }

            if (category == null)
            {
                return NotFound();
            }

            var book = new Book
            {
                Title = bookDTO.Title,
                Image = bookDTO.Image,
                Category = category,
                Authors = authors
            };


            _bookContext.Add(book);
            await _bookContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        //[HttpPut("{id}")]
        //public IActionResult Update(Guid id, Book book)
        //{
        //    if (id != book.Id)
        //    {
        //        return BadRequest();
        //    }

        //    var existingBook = BookService.Get(id);

        //    if (existingBook is null)
        //    {
        //        return NotFound();,
        //    }

        //    try
        //    {
        //        BookService.Update(id, book);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        return BadRequest();
        //    }
        //    return NoContent();
        //}

        //[HttpDelete]
        //public IActionResult Delete(Guid id)
        //{
        //    var book = BookService.Get(id);

        //    if(book is null)
        //    {
        //        return NotFound();
        //    }

        //    try
        //    {
        //        BookService.Delete(id);
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        return BadRequest();
        //    }

        //}
    }
}
