using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("Content can not be empty.");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Content can have a maximum of 500 characters.");
        }
    }
}
