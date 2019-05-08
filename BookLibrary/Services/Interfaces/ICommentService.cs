using Services.DTO;
using Services.Filters;

namespace Services.Interfaces
{
    public interface ICommentService : IService<CommentDTO, CommentFilter>
    {
    }
}
