using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can not be empty.");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("Email can have a maximum of 150 characters.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter an email address format");

            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Name Surname can not be empty.");
            RuleFor(x => x.NameSurname).MaximumLength(100).WithMessage("Name Surname can have a maximum of 100 characters.");

            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone field can not be empty.");
            RuleFor(x => x.Phone).MaximumLength(20).WithMessage("Phone can have a maximum of 20 characters.");

            RuleFor(x => x.Address).NotEmpty().WithMessage("Address can not be empty.");
            RuleFor(x => x.Address).MaximumLength(500).WithMessage("Address field can have a maximum of 500 characters.");
        }
    }
}
