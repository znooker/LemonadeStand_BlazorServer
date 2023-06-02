
using _1.Domain.Fruits;
using _1.Domain.Recipies;
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

            RuleFor(o => o.SelectedRecipe).NotNull().WithMessage("A jummy juice must be selected!");


            RuleFor(o => o.GlassesToServe).
                Cascade(CascadeMode.StopOnFirstFailure).
                NotNull().WithMessage("Specify how many glasses you want.").
                NotEmpty().WithMessage("Specify how many glasses you want.").
                GreaterThan(0).WithMessage("More than zero...!").
                LessThanOrEqualTo(int.MaxValue).WithMessage("To large order!");

            When(o => o.GlassesToServe > 0 && o.SelectedRecipe is not null,() =>
            {
                RuleFor(o => o.MoneyPaid).
                Cascade(CascadeMode.StopOnFirstFailure).
                NotEmpty().WithMessage("Please pay... I need to feed my family...").
                GreaterThan(0).WithMessage("Add cash now... or else!!").
                GreaterThanOrEqualTo(o => o.GlassesToServe * o.SelectedRecipe.PricePerGlass).WithMessage(o => $"To little cash! Sum of order is {o.GlassesToServe * o.SelectedRecipe.PricePerGlass:C}");


                RuleFor(o => o.Fruits).
                Cascade(CascadeMode.StopOnFirstFailure).
                NotNull().WithMessage("Add a fruit!").
                NotEmpty().WithMessage(o => $"Must add {o.SelectedRecipe.ConsumptionPerGlass * o.GlassesToServe} {o.SelectedRecipe.AllowedFruit.Name}(s)").
                Must((o, Fruits) => Fruits.All(List => List.GetType() == o.SelectedRecipe.AllowedFruit)).WithMessage(o => $"{o.SelectedRecipe.Name} only contains {o.SelectedRecipe.AllowedFruit.Name}(s)!").
                Must((o, Fruits) => Fruits.Count >= (o.SelectedRecipe.ConsumptionPerGlass * o.GlassesToServe)).WithMessage(o => $"Need more fruits, add atleast {o.SelectedRecipe.ConsumptionPerGlass * o.GlassesToServe} {o.SelectedRecipe.AllowedFruit.Name}(s)!");
                

            });


        }
    }
}


