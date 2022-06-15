using HamsterWarsV2;
using HamsterWarsV2.Services;
using HamsterWarsV2.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7037")});
builder.Services.AddScoped<IHamsterService, HamsterService>();

await builder.Build().RunAsync();
