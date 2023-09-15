using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Barcodeno).NotEmpty().WithMessage("Barcode can not be empty.");
            RuleFor(x => x.Barcodeno).MaximumLength(30).WithMessage("Barcode can have a maximum of 30 characters.");
            RuleFor(x => x.BookName).NotEmpty().WithMessage("Book name can not be empty.");
            RuleFor(x => x.BookName).MaximumLength(100).WithMessage("Book name can have a maximum of 100 characters.");
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Author name can not be empty.");
            RuleFor(x => x.AuthorName).MaximumLength(100).WithMessage("Author name can have a maximum of 100 characters.");
            RuleFor(x => x.Publisher).NotEmpty().WithMessage("Publisher name can not be empty.");
            RuleFor(x => x.Publisher).MaximumLength(150).WithMessage("Publisher name can have a maximum of 150 characters.");
        }
    }
}
