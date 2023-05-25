using _1.Domain.Fruits;
using _1.Domain.Recipies;
using _2.Application;
using _2.Application.Extentions;
using _4.Presentation;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _0.Test.Application.Extensions
{
    public  class FruitExtentionsTest
    {
        //[Fact]
        //public void FruitPressService_ShouldReturn_FruitPressResult()
        //{
        //    //Arrange
        //    var service = new FruitPressService();
        //    var expected = new FruitPressResult();
        //    var recipe = new Recipe() { AllowedFruit = typeof(Apple), ConsumptionPerGlass = 2.5M, Name = "testRecipe", PricePerGlass = 10, ImagePath = "" };
        //    var fruits = new Collection<IFruit> { new Apple(), new Orange() };

        //    //Act
        //    var result = service.Produce(recipe,fruits, 10, 1);

        //    //Assert
        //    result.Should().BeEquivalentTo(expected);

        //}

        [Fact]
       public void A_Type_ShouldReturn_A_ClassInstance_Of_Apple()
        {
            
            //Arrange
            Type type = typeof(Apple);
            IFruit expected = new Apple();

            //Act
            var result = type.CreateFruitClassFromType();

            //Assert
             result.Should().BeEquivalentTo(expected);
        }

    }
}
