using Entities.Validations;
using FluentValidation.Attributes;
using System;

namespace Entities.Model
{
    [Validator(typeof(NoticeValidator))]
    public class Notice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Announcement { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
