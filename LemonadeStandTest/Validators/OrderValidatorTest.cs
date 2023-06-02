using _1.Domain.Fruits;
using _1.Domain.Recipies;
using _2.Application.Models;
using _2.Application.Validators;
using FluentAssertions;
using FluentValidation.TestHelper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandTest.Validators
{
    public class OrderValidatorTest
    {
       


        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(null)]
        public void GlassesToServe_ShouldHaveValidationError(int value)
        {
            OrderModel order = new OrderModel() { GlassesToServe = value};
            OrderValidator validator = new OrderValidator();

            var result = validator.TestValidate(order);

            result.ShouldHaveValidationErrorFor(o => o.GlassesToServe);
        
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(int.MaxValue)]
        public void GlassesToServe_ShouldNotHaveValidationError(int value)
        {
            OrderValidator validator = new OrderValidator();
            IRecipe recipe = new Recipe() { AllowedFruit = typeof(Apple), ConsumptionPerGlass = 1, PricePerGlass = 2, ImagePath = "/path", Name ="test"};
            OrderModel order = new OrderModel() { GlassesToServe = value, SelectedRecipe = recipe};

            var result = validator.TestValidate(order);

            result.ShouldNotHaveValidationErrorFor(o => o.GlassesToServe);
        }


        [Fact]
      
        public void GlassesToServe_ShouldNotHaveValidationErrorFact()
        {
            OrderValidator validator = new OrderValidator();
            OrderModel order = new OrderModel() { GlassesToServe = 3 };

            var result = validator.TestValidate(order);

            result.ShouldNotHaveValidationErrorFor(o => o.GlassesToServe);
        }



        [Fact]
        public void SelectedRecipe_ShouldNotBeNull()
        {
            IRecipe recipe = new Recipe() { AllowedFruit = typeof(Apple), ConsumptionPerGlass = 1, PricePerGlass = 2, ImagePath = "/path", Name = "test" };
            OrderValidator validator = new OrderValidator();
            OrderModel order = new OrderModel() { SelectedRecipe = recipe };

            var result = validator.TestValidate(order);

            result.ShouldNotHaveValidationErrorFor(o => o.SelectedRecipe);
        }

        [Fact]
        public void MoneyPaid_ShouldNotBeNull()
        {
            OrderValidator validator = new OrderValidator();
            IRecipe recipe = new Recipe() { AllowedFruit = typeof(Apple), ConsumptionPerGlass = 1, PricePerGlass = 2, ImagePath = "/path", Name = "test" };
            OrderModel order = new OrderModel() { GlassesToServe = 1, SelectedRecipe = recipe, MoneyPaid = 2, Fruits = new() { new Apple(), new Orange() } };

            var result = validator.TestValidate(order);

            result.ShouldNotHaveValidationErrorFor(o => o.MoneyPaid);

        }




    }
}
