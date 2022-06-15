using Domain.Entities.Models;
using HamsterWarsV2.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace HamsterWarsV2.Pages
{
    public class HamsterBattleBase : ComponentBase
    {
        [Inject]
        public IHamsterService HamsterService { get; set; }

        public IEnumerable<Hamster> Hamsters { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Hamsters =  await HamsterService.GetTwoRandomHamsters();
    
        }

    








    }
}
