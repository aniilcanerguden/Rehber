using FluentValidation;
using Rehber.Entity.Model;
using Rehber.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entity.Validators
{
   public class UserValidator:AbstractValidator<UserModel>
    {

        public UserValidator()
        {
            RuleFor(x => x.UserMail).NotNull().WithMessage("Email Boş olamaz");
            RuleFor(x => x.UserMail).EmailAddress().WithMessage("Doğru bir Email giriniz.");
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Lütfen şifreyi boş girmeyiniz");

        }

    }
}
