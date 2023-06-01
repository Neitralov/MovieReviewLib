using ElectronNET.API;
using Blazored.LocalStorage;
using ElectronNET.API.Entities;
using MovieReviewLib.Data;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseElectron(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

await app.StartAsync();

var window = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
{
    MinWidth = 900,
    MinHeight = 600
});
window.RemoveMenu();

app.WaitForShutdown();