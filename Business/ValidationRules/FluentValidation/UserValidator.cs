using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty().MinimumLength(2);  //Boş geçilemez , en az 2 karakter olmalı
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.TelephoneNumber).NotEmpty().WithMessage("Telefon numarası 10 haneli olarak , başında 0 olmadan girilmelidir");
        }
    }
}
