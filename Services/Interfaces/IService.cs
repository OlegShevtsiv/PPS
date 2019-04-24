using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IService<TDto, TFilter>
    {
        TDto Get(int id);
        IEnumerable<TDto> Get(TFilter filter);
        void Add(TDto dto);
        void Remove(int id);
        void Update(TDto dto);
    }
}
