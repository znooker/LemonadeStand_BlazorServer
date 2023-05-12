using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application.Models
{
    public class OrderModel
    {
        public string SelectedRecipeName { get; set; }
        public int GlassesToServe { get; set; }
        public int MoneyPaid { get; set; }
        public int NumberOfApples { get; set; }
        public int NumberOfMelons { get; set; }
        public int NumberOfOranges { get; set; }
    }
}
