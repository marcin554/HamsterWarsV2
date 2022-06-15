using Domain.Entities.Models;
using HamsterWarsV2.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace HamsterWarsV2.Pages.HamsterComponent
{
    public class HamsterGalleryBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<Hamster> Hamsters { get; set; }

        [Inject]
        public IHamsterService HamsterService { get; set; }

 
    }
}
