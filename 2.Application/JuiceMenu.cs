using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Application
{
    public class JuiceMenu : IJuiceMenu
    {
        public List<IRecipe> Menu { get; } = new List<IRecipe>();

        public JuiceMenu()
        {
            Menu.Add(new AppleJuice());
            Menu.Add(new OrangeJuice());
            Menu.Add(new MelonJuice());
        }
   
    }
}
