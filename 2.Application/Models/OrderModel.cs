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

      
        public IRecipe SelectedRecipe { get; set; }

        //public string? SelectedRecipeName { get; set; } - Not Used anymore
        
        public int? GlassesToServe { get; set; }
     
        public int? MoneyPaid { get; set; }

   
        public  bool ValidFruitsInRecipe { get; set; }

        public List<IFruit>? Fruits { get; set; } = new();

     


    }

    
}
