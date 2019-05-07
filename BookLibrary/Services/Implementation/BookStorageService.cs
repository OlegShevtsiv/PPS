using DataAccess.Interfaces;
using DataAccess.Models;
using Services.DTO;
using Services.Exceptions;
using Services.Filters;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Services.Implementation
{
    public class BookStorageService : Service<BookStorage, BookStorageDTO, BookStorageFilter>, IBookStorageService
    {
        public BookStorageService(IUnitOfWork unitOfWork) :
            base(unitOfWork)
        {
        }

        public override BookStorageDTO Get(string id)
        {
            BookStorage entity = Repository
              .Get(e => e.Id == id)
              .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            return MapToDto(entity);
        }

        public override IEnumerable<BookStorageDTO> Get(BookStorageFilter filter)
        {
            Func<BookStorage, bool> predicate = GetFilter(filter);
            List<BookStorage> entities = Repository
              .Get(p => predicate(p))
              .ToList();

            if (!entities.Any())
            {
                throw new ObjectNotFoundException();
            }

            return entities.Select(e => MapToDto(e));
        }

        public override IEnumerable<BookStorageDTO> GetAll()
        {
            List<BookStorage> entities = Repository
              .Get(p => p != null)
              .ToList();

            //if (!entities.Any())
            //{
            //    throw new ObjectNotFoundException();
            //}

            return entities.Select(e => MapToDto(e));
        }

        public override void Add(BookStorageDTO dto)
        {
            BookStorage checkEntity = Repository
                .Get(e => e.Id == dto.Id)
                .SingleOrDefault();

            if (checkEntity != null)
            {
                throw new DuplicateNameException();
            }

            BookStorage entity = MapToEntity(dto);
            Repository.Add(entity);
            _unitOfWork.SaveChangesAsync();
        }

        public override void Remove(string id)
        {
            BookStorage entity = Repository
             .Get(e => e.Id == id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            Repository.Remove(entity);
            _unitOfWork.SaveChangesAsync();
        }

        public override void Update(BookStorageDTO dto)
        {
            BookStorage entity = Repository
             .Get(e => e.Id == dto.Id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            entity.Url = dto.Url;


            Repository.Update(entity);
            _unitOfWork.SaveChangesAsync();
        }

        protected override BookStorageDTO MapToDto(BookStorage entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            BookStorageDTO dto = new BookStorageDTO
            {
                Id = entity.Id,
                Url = entity.Url,

            };

            return dto;
        }

        protected override BookStorage MapToEntity(BookStorageDTO dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            BookStorage entity = new BookStorage
            {
                Id = dto.Id,
                Url = dto.Url,

            };

            return entity;
        }

        private Func<BookStorage, bool> GetFilter(BookStorageFilter filter)
        {
            Func<BookStorage, bool> result = e => true;
            if (!String.IsNullOrEmpty(filter?.Url))
            {
                result += e => e.Url == filter.Url;
            }

            return result;
        }
    }
}
