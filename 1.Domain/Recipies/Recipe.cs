using _1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Recipies
{
    [TypeConverter(typeof(RecipeConverter))]
    public class Recipe : IRecipe
    {
        public string Name { get; set; }

        public Type AllowedFruit { get; set; }

        public decimal ConsumptionPerGlass { get; set; }

        public int PricePerGlass { get; set; }

        public string ImagePath { get; set; }
    }

    internal class RecipeConverter :TypeConverter
    {
      
            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                if (sourceType == typeof(string))
                    return true;

                return base.CanConvertFrom(context, sourceType);
            }

            public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
                if (value is string recipeString)
                {
                    // Parse the string and create a new instance of Recipe
                    var recipe = new Recipe();

                    // Implement the logic to populate the properties of the recipe object based on the string representation
                    // Split the recipeString into individual values (e.g., using a delimiter like '|')
                    // Assign the split values to the corresponding properties of the recipe object

                    return recipe;
                }

                return base.ConvertFrom(context, culture, value);
            }
        
    }
}
