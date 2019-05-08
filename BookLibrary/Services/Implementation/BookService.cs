﻿using DataAccess.Implementation;
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
    public class BookService :Service<Book, BookDTO, BookFilter>, IBookService
    {
        public BookService(IUnitOfWork unitOfWork) :
            base(unitOfWork)
        {
        }

        public override BookDTO Get(string id)
        {
            Book entity = Repository
              .Get(e => e.Id == id)
              .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            return MapToDto(entity);
        }

        public override IEnumerable<BookDTO> Get(BookFilter filter)
        {
            Func<Book, bool> predicate = GetFilter(filter);
            List<Book> entities = Repository
              .Get(p => predicate(p))
              .ToList();

            if (!entities.Any())
            {
                throw new ObjectNotFoundException();
            }

            return entities.Select(e => MapToDto(e));
        }

        public override IEnumerable<BookDTO> GetAll()
        {
            List<Book> entities = Repository
              .Get(p => p != null)
              .ToList();

            //if (!entities.Any())
            //{
            //    throw new ObjectNotFoundException();
            //}

            return entities.Select(e => MapToDto(e));
        }

        public override void Add(BookDTO dto)
        {
            Book checkEntity = Repository
                .Get(e => e.Id == dto.Id)
                .SingleOrDefault();

            //if (checkEntity != null)
            //{
            //    throw new DuplicateNameException();
            //}

            Book entity = MapToEntity(dto);
            Repository.Add(entity);
            _unitOfWork.SaveChangesAsync();
        }

        public override void Remove(string id)
        {
            Book entity = Repository
             .Get(e => e.Id == id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            Repository.Remove(entity);
            _unitOfWork.SaveChangesAsync();
        }
        public override void Update(BookDTO dto)
        {
            Book entity = Repository
             .Get(e => e.Id == dto.Id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new ObjectNotFoundException();
            }

            entity.Title = dto.Title;
            entity.Description = dto.Description;
            entity.AuthorId = dto.AuthorId;
            entity.Rate = dto.Rate;
            entity.Image = dto.Image;
            entity.FileBook = dto.FileBook;
            entity.Year = dto.Year;
            entity.Genre = dto.Genre;
        
            Repository.Update(entity);
            _unitOfWork.SaveChangesAsync();
        }

        protected override BookDTO MapToDto(Book entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            BookDTO dto = new BookDTO
            {
                Id = entity.Id,
                Title = entity.Title,
                AuthorId = entity.AuthorId,
                Image = entity.Image,
                FileBook = entity.FileBook,
                Rate = entity.Rate,
                Year = entity.Year,
                Description = entity.Description,
                Genre = entity.Genre
            };

            return dto;
        }

        protected override Book MapToEntity(BookDTO dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            Book entity = new Book
            {
                Id = dto.Id,
                Title = dto.Title,
                AuthorId = dto.AuthorId,
                Image = dto.Image,
                FileBook = dto.FileBook,    
                Rate = dto.Rate,
                Year = dto.Year,
                Description = dto.Description,
                Genre = dto.Genre
            };

            return entity;
        }

        private Func<Book, bool> GetFilter(BookFilter filter)
        {
            Func<Book, bool> result = e => true;
            if (!String.IsNullOrEmpty(filter?.Title))
            {
                result += e => e.Title == filter.Title;
            }

            return result;
        }
    }
}
