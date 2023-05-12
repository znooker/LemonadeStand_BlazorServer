using _1.Domain.Recipies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace _2.Application
{
    public interface IJuiceMenu
    {
       List<IRecipe> Menu { get; }

    
    }
}
