using Entities.Validations;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    [Validator(typeof(MemberValidator))]
    public class Member
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public int ReadBookNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<SafetyBook> SafetyBook { get; set; }
    }
}
