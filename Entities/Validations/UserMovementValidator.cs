using Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations
{
    public class UserMovementValidator : AbstractValidator<UserMovement>
    {
        public UserMovementValidator()
        {
            
        }
    }
}
