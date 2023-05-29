using _1.Domain.Fruits;
using _1.Domain.Recipies;
using _2.Application;
using _2.Application.Extentions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application
{
    public class FruitPressService : IFruitPressService
    {
        FruitPressResult result = new FruitPressResult();

        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {


            result.Recipe = recipe;
            result.GlassesToServe = orderedGlassQuantity;
            result.MoneyPaid = moneyPaid;
            
            //Still needed after validation??
            result.ErrorMessage = "";

            result.FruitLeft = fruits.FruitsLeftAfterProcessing(recipe, orderedGlassQuantity);
            result.Fruit = recipe.AllowedFruit;
            result.MoneyBack = moneyPaid.CalculateChange(recipe, orderedGlassQuantity);

            result.IsSuccess = true;

            return result;
        }

    
    }
}
