using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Fruits
{
    public class Melon : IFruit
    {
        public string Name { get; } = "Melon";
        public int Amount { get; set; }
    }
}
