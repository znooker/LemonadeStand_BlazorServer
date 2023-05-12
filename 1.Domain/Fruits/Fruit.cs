using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.Fruits
{
    public class Fruit : IFruit
    {

        public string Name { get; }
        public int TotalStore { get; set; }

    }
}
