
using _1.Domain.Recipies;
using _2.Application;
using Microsoft.AspNetCore.Components;

namespace _4.Presentation.Pages
{
    public partial class JuiceMenuComponent
    {
           
        List<IRecipe> CurrentMenu = new List<IRecipe>();

        protected override void OnInitialized()
        {
            JuiceMenu menu = new JuiceMenu();
            CurrentMenu = menu.Menu;
            base.OnInitialized();
        }
    }
}