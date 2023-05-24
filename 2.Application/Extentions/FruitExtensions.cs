using _1.Domain.Fruits;
using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application.Extentions
{
    public static class FruitExtensions
    {

        public static List<IFruit> UpdateFruits(this List<IFruit> Fruits, int amount, Type fruit)
        {
            var tempFruits = new List<IFruit>();

            if (Fruits is not null)
            {
                Fruits.RemoveAll(f => f.GetType() == fruit);
                tempFruits = Fruits;
            }

            IFruit tempFruit = null;

            switch (fruit.Name.ToLower())
            {
                case "apple":
                    
                        tempFruit = new Apple();
                    break;
                case "orange":

                    tempFruit = new Orange();
                    break;
                case "melon":

                    tempFruit = new Melon();
                    break;

                default:
                    break;
            }


            for (int i = 0; i < amount; i++)
            {
                tempFruits.Add(tempFruit);
            }

            return tempFruits;
        }

       public static Collection<IFruit> ConvertToCollection(this List<IFruit> Fruits)
        {
            Collection<IFruit> _fruits = new();
            foreach (var item in Fruits)
            {
                _fruits.Add(item);
            }
            return _fruits;
        }


    }



}
