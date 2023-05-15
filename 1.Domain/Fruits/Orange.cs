using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Fruits
{
    public class Orange : IFruit
    {
        public string Name { get; } = "Orange";
        public int Amount { get; set; }
    }
}
