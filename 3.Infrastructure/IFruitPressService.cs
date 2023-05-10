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
    public interface IFruitPressService
    {
        FruitPressResult Produce(
            IRecipe recipe,
            Collection<IFruit> fruits,
            int moneyPaid,
            int orderedGlassQuantity
            );
    }

}