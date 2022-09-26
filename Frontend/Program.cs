using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Frontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(
    sp => new HttpClient {
        BaseAddress = new Uri("https://skbigoven.azurewebsites.net/api/")
    }
);
builder.Services.AddBlazoredLocalStorage();
await builder.Build().RunAsync();