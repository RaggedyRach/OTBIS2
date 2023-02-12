using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using OTBIS.Web;
using OTBIS.Web.Areas.Identity;
using OTBIS.Web.Data;
using OTBIS.Web.Data.Interfaces;
using OTBIS.Web.Data.Production;
using OTBIS.Web.Services;

using Radzen;
using Radzen.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var connectionStringStaging = builder.Configuration.GetConnectionString("Staging");



builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<StagingDbContext>(options =>
    options.UseSqlServer(connectionStringStaging), ServiceLifetime.Transient);





builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();


builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddScoped<GetProductionService>();
builder.Services.AddScoped<GetChartDataService>();
builder.Services.AddScoped<GetDomainDataService>();
builder.Services.AddScoped<GetDeptDataService>();
builder.Services.AddScoped<GetCatDataService>();
builder.Services.AddScoped<GetSubCatDataService>();
builder.Services.AddScoped<GetItemDataService>();
builder.Services.AddScoped<GetTillDataService>();
builder.Services.AddScoped<ComparedOnService>();
builder.Services.AddScoped<PopulateDropdownService>();

builder.Services.AddSingleton<MyStateContainer>();
builder.Services.AddSingleton<MyStateContainer2>();
builder.Services.AddSingleton<MyStateContainer3>();

var app = builder.Build();


    

   

 //  await builder.Build().RunAsync();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
