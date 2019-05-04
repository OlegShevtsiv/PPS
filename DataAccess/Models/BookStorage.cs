﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class BookStorage
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public BookStorage() { }

        public BookStorage(int _id, string _url)
        {
            Id = _id;
            Url = _url;
        }
    }
}