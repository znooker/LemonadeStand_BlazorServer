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
    public class PressFruit : IFruitPressService
    {
        public FruitPressResult Result { get;  } = new FruitPressResult();

        //public FruitPressResult Result { get; set; }
       
        //Flytta Menyn någon annanstans.... där den ska presenteras....
        public List<IRecipe> JuiceMenu { get; } = new List<IRecipe>()
        {
            new AppleJuice(),
            new MelonJuice(),
            new OrangeJuice()
        };

        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            //Se om receptet och de beställda frukterna överensstämmer.
            if((fruits.All(f => f.GetType() == recipe.AllowedFruit) == false))
            {
                Result.GlassesToServe = 0;
                Result.Message = "A valid recipe could not be found for that fruit combination";
                return Result;
            }

            //Se om den betalda summan täcker beställningen
            if (moneyPaid < (recipe.PricePerGlass * orderedGlassQuantity))
            {
                Result.Message = $"Not enough money! \n Totalcost is: {recipe.PricePerGlass * orderedGlassQuantity}";
                return Result ;
            }
                       
            
            
            //Allt ok!
            Result.Message = orderedGlassQuantity > 1 ? $"Here is your order of {orderedGlassQuantity} glasses of {recipe.Name}" : $"Here is your order of {orderedGlassQuantity} glass of {recipe.Name}";
            
            return Result;
        }
    }
}
