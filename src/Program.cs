using DashboardPOC.Components;
using DashboardPOC.Interfaces;
using DashboardPOC.Services;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.PreventDuplicates = true;
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
});

builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddSingleton<IThemeService, ThemeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
#pragma warning disable IDE0058 // Expression value is never used
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
#pragma warning restore IDE0058 // Expression value is never used
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
