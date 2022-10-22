using EmployeeAuthCrud.UI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EmployeeAuthCrud.UI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7051/api/employee") });
//builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(
//              client => client.BaseAddress = new Uri("https://localhost:7051"));

//builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(
//    client => client.BaseAddress = new Uri("https://localhost:7051"));
await builder.Build().RunAsync();
