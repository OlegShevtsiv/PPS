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
    public class AuthorService : Service<Author, AuthorDTO, AuthorFilter>, IAuthorService
    {
        public AuthorService(IUnitOfWork unitOfWork) :
            base(unitOfWork)
        {
        }

        public override AuthorDTO Get(string id)
        {
            Author entity = Repository
              .Get(e => e.Id == id)
              .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            return MapToDto(entity);
        }

        public override IEnumerable<AuthorDTO> Get(AuthorFilter filter)
        {
            Func<Author, bool> predicate = GetFilter(filter);
            List<Author> entities = Repository
              .Get(p => predicate(p))
              .ToList();

            if (!entities.Any())
            {
                throw new ObjectNotFoundException();
            }

            return entities.Select(e => MapToDto(e));
        }

        public override IEnumerable<AuthorDTO> GetAll()
        {
            List<Author> entities = Repository
              .Get(p => p != null)
              .ToList();

            //if (!entities.Any())
            //{
            //    throw new ObjectNotFoundException();
            //}

            return entities.Select(e => MapToDto(e));
        }

        public override void Add(AuthorDTO dto)
        {
            Author checkEntity = Repository
                .Get(e => e.Id == dto.Id)
                .SingleOrDefault();

            if (checkEntity != null)
            {
                throw new DuplicateNameException();
            }

            Author entity = MapToEntity(dto);
            Repository.Add(entity);
            _unitOfWork.SaveChangesAsync();
        }

        public override void Remove(string id)
        {
            Author entity = Repository
             .Get(e => e.Id == id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            Repository.Remove(entity);
            _unitOfWork.SaveChangesAsync();
        }
        public override void Update(AuthorDTO dto)
        {
            Author entity = Repository
             .Get(e => e.Id == dto.Id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            entity.Name = dto.Name;
            entity.Surname = dto.Surname;
            entity.Description = dto.Description;
            entity.Image = dto.Image;

            Repository.Update(entity);
            _unitOfWork.SaveChangesAsync();
        }

        protected override AuthorDTO MapToDto(Author entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            AuthorDTO dto = new AuthorDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Surname = entity.Surname,
                Description = entity.Description,
                Image = entity.Image
            };

            return dto;
        }

        protected override Author MapToEntity(AuthorDTO dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            Author entity = new Author
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname = dto.Surname,
                Description = dto.Description,
                Image = dto.Image
            };

            return entity;
        }

        private Func<Author, bool> GetFilter(AuthorFilter filter)
        {
            Func<Author, bool> result = e => true;
            if (!String.IsNullOrEmpty(filter?.Name))
            {
                result += e => e.Name == filter.Name;
            }

            return result;
        }
    }
}
