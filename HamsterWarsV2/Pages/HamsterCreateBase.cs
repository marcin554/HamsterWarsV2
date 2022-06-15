using HamsterWarsV2.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace HamsterWarsV2.Pages
{
    public class HamsterCreateBase : ComponentBase
    {
        [Inject]
        public IHamsterService HamsterService { get; set; }
    }
}
