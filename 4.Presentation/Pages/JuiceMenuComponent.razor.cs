
using _1.Domain.Recipies;
using _2.Application;
using Microsoft.AspNetCore.Components;

namespace _4.Presentation.Pages
{
    public partial class JuiceMenuComponent
    {
        [Inject]
        public IJuiceMenu _juiceMenu { get; set; }
    
        List<IRecipe> CurrentMenu = new List<IRecipe>();

        protected override void OnInitialized()
        {
            CurrentMenu = _juiceMenu.Menu;
            base.OnInitialized();
        }
    }
}