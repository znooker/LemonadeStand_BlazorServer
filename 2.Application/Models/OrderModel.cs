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

        //Change to interface IRecipe
        [Required(ErrorMessage = "A jummy juice must be selected!")]
        public string SelectedRecipeName { get; set; }

        [Required(ErrorMessage = "Please speciy how many glasses to serve!")]
        [RegularExpression(@"^0*?[1-9]\d*$", ErrorMessage = "Please enter a number greater than 0!")]
        public int? GlassesToServe { get; set; }
        [Required(ErrorMessage = "Add cash now... or else!!")]
        [RegularExpression(@"^0*?[1-9]\d*$", ErrorMessage = "Please enter a number greater than 0!")]
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
