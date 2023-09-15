using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class BookRecordMovementValidator : AbstractValidator<BookRecordMovement>
    {
        public BookRecordMovementValidator()
        {
            RuleFor(x => x.ActionTaken).MaximumLength(150).WithMessage("Action taken can have a maximum of 150 characters.");
        }
    }
}
