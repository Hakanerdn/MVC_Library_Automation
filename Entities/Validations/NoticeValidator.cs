using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class NoticeValidator : AbstractValidator<Notice>
    {
        public NoticeValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can not be empty.");
            RuleFor(x => x.Announcement).NotEmpty().WithMessage("Announcement can not be empty.");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Date can not be empty.");
            RuleFor(x => x.Title).Length(5, 150).WithMessage("Title should be 5 - 150 characters.");
            RuleFor(x => x.Announcement).MaximumLength(500).WithMessage("Announcement can have a maximum of 500 characters.");
        }
    }
}
