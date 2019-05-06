using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Models
{

    public class User : IdentityUser
    {
        public string Name { get; set; }
        public User() { }
    }
}

