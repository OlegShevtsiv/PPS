using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Models
{

    public enum Role
    {
        USER,
        USER_ADMIN,
        LIBRARY_ADMIN
    }

    public class User : IdentityUser
    {
        [DataType(DataType.Date)]
        public Role Role { get; set; }
        public string Name { get; set; }

        public User() { }
    }
}

