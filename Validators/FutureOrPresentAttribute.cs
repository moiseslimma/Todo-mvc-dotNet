using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Validators
{
    public class FutureOrPresentAttribute : ValidationAttribute
    {
        public FutureOrPresentAttribute()
        {
            ErrorMessage = "O campo {0} deve ser uma data futura ou presente";
        }

        public override bool IsValid(object? value)
        {
            if(value is null)
            {
                return true;
            }
            var date = (DateOnly)value;
            return date >= DateOnly.FromDateTime(DateTime.Now);
        }
    }
}