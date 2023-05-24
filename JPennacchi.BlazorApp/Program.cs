using JPennacchi.BlazorApp;
using JPennacchi.BlazorApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient(nameof(FileService), client => client.BaseAddress = new Uri("https://localhost:7023"));
builder.Services.AddScoped<FileService>();

await builder.Build().RunAsync();
