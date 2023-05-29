using _1.Domain.Fruits;
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
