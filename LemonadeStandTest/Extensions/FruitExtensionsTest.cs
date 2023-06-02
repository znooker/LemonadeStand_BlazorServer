using _1.Domain.Fruits;
using _1.Domain.Recipies;
using _2.Application;
using _2.Application.Extentions;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandTest.Extensions
{
    public class FruitExtensionsTest
    {
        [Fact]
        public void CreateFruitClassFromType_TypeofApple_ShouldReturnApple()
        {

            //Arrange
            Type type = typeof(Apple);
            IFruit expected = new Apple();

            //Act
            var result = type.CreateFruitClassFromType();

            //Assert
            result.Should().BeEquivalentTo(expected);
        }
        [Fact]
        public void CreateFruitClassFromType_TypeofOrange_ShouldReturnOrange()
        {

            //Arrange
            Type type = typeof(Orange);
            IFruit expected = new Orange();

            //Act
            var result = type.CreateFruitClassFromType();

            //Assert
            result.Should().BeEquivalentTo(expected);
        }
        [Fact]
        public void CreateFruitClassFromType_TypeofMelon_ShouldReturnMelon()
        {

            //Arrange
            Type type = typeof(Melon);
            IFruit expected = new Melon();

            //Act
            var result = type.CreateFruitClassFromType();

            //Assert
            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(10, 5, 1, 5)]
        [InlineData(5, 5, 1, 0)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, 2, -2, 3)]
        public void CalculateChange_MoneyPaid_ShouldReturnChangeLeft(int moneyPaid, int recipeCost, int orderedGlassQuantity, int expected)
        {
            IRecipe testRecipe = new Recipe();
            testRecipe.PricePerGlass = recipeCost;

            var result = moneyPaid.CalculateChange(testRecipe, orderedGlassQuantity);

            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(0);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("-1", -1)]
        [InlineData("", 0)]
        [InlineData("9999", 9999)]
        [InlineData("0", 0)]
        public void ParseValueOrReturnZero_ShouldReturnInt(string value, int expected)
        {
            var result = value.ParseValueOrReturnZero();

            result.Should().Be(expected);

        }


        //Till annan xunit test fil, är inte en extension
        [Fact]
        public void Produce_ShouldReturn_FruitPressResult()
        {
            //Arr
            var service = new FruitPressService();


            //Act

            //Ass
        }

    }
}
