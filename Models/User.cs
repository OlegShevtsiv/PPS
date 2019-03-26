using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class User
    {
        public int Id { get; set; }
        public string LoginName { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        public bool IsAdmin { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}

