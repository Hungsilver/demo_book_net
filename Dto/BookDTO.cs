using CRUD_ASP.NET_CORE.Models;

namespace CRUD_ASP.NET_CORE.Dto
{
    public class BookDTO
    {
        public string? Title { set; get; }
        public string? Image { set; get; }
        public List<Guid>? Authors { set; get; }
        public string? Category { set; get; }
    }
}
