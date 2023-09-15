using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class CommunicationValidator : AbstractValidator<Communication>
    {
        public CommunicationValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can not be empty.");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("Email can have a maximum of 150 characters.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter an email address format");

            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Name Surname can not be empty.");
            RuleFor(x => x.NameSurname).MaximumLength(100).WithMessage("Name Surname can have a maximum of 100 characters.");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can not be empty.");
            RuleFor(x => x.Title).MaximumLength(200).WithMessage("Title can have a maximum of 200 characters.");

            RuleFor(x => x.Message).NotEmpty().WithMessage("Message can not be empty.");
            RuleFor(x => x.Message).MaximumLength(500).WithMessage("Message can have a maximum of 500 characters.");

        }
    }
}
