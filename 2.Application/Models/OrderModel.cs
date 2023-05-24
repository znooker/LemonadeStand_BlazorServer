using _1.Domain.Fruits;
using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application.Models
{
    public class OrderModel
    {

        //Rethink the model!
        public IRecipe SelectedRecipe { get; set; }

        public string? SelectedRecipeName { get; set; }
        
        public int? GlassesToServe { get; set; }
     
        public int? MoneyPaid { get; set; }

        //public string InvalidFruitMix { get; set; }
        public  bool ValidFruitsInRecipe { get; set; }


        //Type fruit??

        public List<IFruit>? Fruits { get; set; } = new();

        //public int Apples { get; set; }
        
        //public int Oranges { get; set; }
    
        //public int Melons { get; set; }



    }

    
}
