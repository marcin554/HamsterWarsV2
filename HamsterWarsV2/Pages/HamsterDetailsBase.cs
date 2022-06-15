using Domain.Entities.Models;
using HamsterWarsV2.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace HamsterWarsV2.Pages
{
    public class HamsterDetailsBase : ComponentBase 
    {
        [Parameter]

        public int HamsterId { get; set; }

        [Inject]
        public IHamsterService HamsterService { get; set; }

        public Hamster hamster { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                hamster = await HamsterService.GetHamsterById(HamsterId);
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }
    }
}
