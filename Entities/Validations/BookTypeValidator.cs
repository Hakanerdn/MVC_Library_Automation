using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class BookTypeValidator : AbstractValidator<BookType>
    {
        public BookTypeValidator()
        {
            RuleFor(x => x.Type).NotEmpty().WithMessage("Book type can not be empty.");
            RuleFor(x => x.Type).MinimumLength(5).WithMessage("The book type can have at least 5 characters.");
            RuleFor(x => x.Type).MaximumLength(150).WithMessage("Book type can have a maximum of 150 characters.");
        }
    }
}
