
using _1.Domain.Recipies;
using _2.Application;
using Microsoft.AspNetCore.Components;

namespace _4.Presentation.Pages
{
    public partial class JuiceMenuComponent
    {
           
        List<IRecipe> CurrentRecipies = new List<IRecipe>();

        protected override void OnInitialized()
        {
            JuiceMenu menu = new JuiceMenu();
            CurrentRecipies = menu.Recipies;
            base.OnInitialized();
        }
    }
}