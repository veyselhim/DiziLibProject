using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FilmValidator:AbstractValidator<Film>
    {
        public FilmValidator()
        {
            RuleFor(f => f.FilmName).NotEmpty();
        }
    }
}
