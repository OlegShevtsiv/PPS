﻿using System.Collections.Generic;
using Services.Interfaces;
using DataAccess.Interfaces;

namespace Services.Implementation
{
    public abstract class Service<TEntity, TDto, TFilter> : IService<TDto, TFilter>
    where TEntity : class
    where TDto : class
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected abstract TDto MapToDto(TEntity entity);
        protected abstract TEntity MapToEntity(TDto dto);

        protected IRepository<TEntity> Repository => _unitOfWork.GetRepository<TEntity>();

        public abstract TDto Get(int id);
        public abstract IEnumerable<TDto> Get(TFilter filter);
        public abstract void Add(TDto dto);
        public abstract void Remove(int id);
        public abstract void Update(TDto dto);
    }
}
