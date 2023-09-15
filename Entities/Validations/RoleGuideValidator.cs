using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class RoleGuideValidator : AbstractValidator<RoleGuide>
    {
        public RoleGuideValidator()
        {
            RuleFor(x => x.Role).NotEmpty().WithMessage("Role can not be empty.");
            RuleFor(x => x.Role).MaximumLength(50).WithMessage("Role can have a maximum of 50 characters.");
        }
    }
}
