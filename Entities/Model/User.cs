using Entities.Validations;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    [Validator(typeof(UserValidator))]
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<UserMovement> UserMovement { get; set; }
        public List<UserRole> UserRole { get; set; }
    }
}
