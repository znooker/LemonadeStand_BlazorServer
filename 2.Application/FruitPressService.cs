using _1.Domain.Fruits;
using _1.Domain.Recipies;
using _2.Application;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application
{
    public class FruitPressService : IFruitPressService
    {
        public FruitPressResult Result { get;  } = new FruitPressResult();
      
        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            Result.Recipe = recipe;
            Result.GlassesToServe = orderedGlassQuantity;
            Result.MoneyPaid = moneyPaid;
            Result.FruitLeft = 0m;
            Result.ErrorMessage = "";

            //Se om receptet och de beställda frukterna överensstämmer.
            if((fruits.All(f => f.GetType() == recipe.AllowedFruit) == false))
            {
                Result.ErrorMessage = "A valid recipe could not be found for that fruit combination";
                return Result;
            }
           

            //Se om den betalda summan täcker beställningen
            if (moneyPaid < (recipe.PricePerGlass * orderedGlassQuantity))
            {
                Result.ErrorMessage = $"Not enough money! \n Totalcost is: {recipe.PricePerGlass * orderedGlassQuantity}";
                return Result ;
            }
            
            return Result;
        }
    }
}
