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
        public int Id { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        public Role Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(int _id, string _email, DateTime _registrationDate, Role _role, string _login, string _password)
        {
            Id = _id;
            Email = _email;
            RegistrationDate = _registrationDate;
            Role = _role;
            Login = _login;
            Password = _password;
        }
    }
}

