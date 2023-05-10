using _1.Domain.Fruits;
using _1.Domain.Recipies;
using _2.Application;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Infrastructure
{
    public class PressFruit : IFruitPressService
    {
        FruitPressResult _result;
        public PressFruit(FruitPressResult result)
        {
            _result = result;
        }


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
                _result.GlassesToServe = 0;
                _result.Message = "A valid recipe could not be found for that fruit combination";
            }

            //Se om den betalda summan täcker beställningen
            //if(moneyPaid > (recipe.PricePerGlass * orderedGlassQuantity)) 
            //{
            //    Result.GlassesToServe = 0;
            //    Result.Message = ""
            //}
            
            return _result;
        }
    }
}
