using Entities.Validations;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    [Validator(typeof(CommunicationValidator))]
    public class Communication
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
