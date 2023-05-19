
using _2.Application.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application.Validators
{
    public class OrderValidator : AbstractValidator<OrderModel>
    {
        public OrderValidator()
        {
            RuleFor(o => o.SelectedRecipeName).
                Cascade(CascadeMode.StopOnFirstFailure).
                NotEmpty().WithMessage("A jummy juice must be selected!");

            RuleFor(o => o.GlassesToServe).
                Cascade(CascadeMode.StopOnFirstFailure).
                NotEmpty().WithMessage("Specify how many glasses you want.").
                GreaterThan(0).WithMessage("More than zero...!");

            RuleFor(o => o.MoneyPaid).
                Cascade(CascadeMode.StopOnFirstFailure).
                NotEmpty().WithMessage("Please pay... I need to feed my family...").
                GreaterThan(0).WithMessage("Add cash now... or else!!");



        }
    }
}
