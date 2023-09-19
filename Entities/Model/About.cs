using Entities.Validations;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    [Validator(typeof(AboutValidator))]
    public class About
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }

    }
}
