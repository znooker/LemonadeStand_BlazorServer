using _1.Domain.Fruits;
using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application.Models
{
    public class OrderModel
    {

        //Rethink the model!
        //Verkar behöva göras en Custom TypeConverter, behöver få en genomgång för att förstå hur den ska implementeras.
        //public IRecipe SelectedRecipe { get; set; }

        public string SelectedRecipeName { get; set; }
        
        public int? GlassesToServe { get; set; }
     
        public int? MoneyPaid { get; set; }
        
        public string InvalidFruitMix { get; set; }


        //Type fruit??
        [Required]
        [RegularExpression(@"^\s*[0-9]+([\,\.][0-9][0-9]{0,2})?$|^$|^\s*$", ErrorMessage = "You must add atleast one Apple")]
        public decimal Apples { get; set; }
        [Required]
        [RegularExpression(@"^\s*[0-9]+([\,\.][0-9][0-9]{0,2})?$|^$|^\s*$", ErrorMessage = "You must add atleast one Orange")]
        public decimal Oranges { get; set; }
        [Required]
        [RegularExpression(@"^\s*[0-9]+([\,\.][0-9][0-9]{0,2})?$|^$|^\s*$", ErrorMessage = "You must add atleast one Melon")]
        public decimal Melons { get; set; }



    }

    
}
