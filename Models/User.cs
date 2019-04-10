using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{

    public enum Role
    {
        USER,
        USER_ADMIN,
        LIBRARY_ADMIN
    }

    public class User
    {
        public int Id { get; set; }
        public string LoginName { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        public Role Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(int _id, string _loginName, DateTime _registrationDate, Role _role, string _login, string _password)
        {
            Id = _id;
            LoginName = _loginName;
            RegistrationDate = _registrationDate;
            Role = _role;
            Login = _login;
            Password = _password;
        }
    }
}

