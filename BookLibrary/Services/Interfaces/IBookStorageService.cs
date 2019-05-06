using Services.DTO;
using Services.Filters;

namespace Services.Interfaces
{
    public interface IBookStorageService : IService<BookStorageDTO, BookStorageFilter>
    {
    }
}
