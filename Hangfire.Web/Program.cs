using Hangfire;
using HangfireBasicAuthenticationFilter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHangfire(config => config.UseSqlServerStorage(builder.Configuration.GetConnectionString("Hangfire")));
builder.Services.AddHangfireServer();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

var hangfireUserName = builder.Configuration.GetSection("HangfireSettings:UserName").Value;
var hangfirePassword = builder.Configuration.GetSection("HangfireSettings:Password").Value;

app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    DashboardTitle = "ekremozer.com",
    Authorization = new[]
    {
        new HangfireCustomBasicAuthenticationFilter{
            User = hangfireUserName,
            Pass = hangfirePassword
        }
    }
});

GlobalJobFilters.Filters.Add(new AutomaticRetryAttribute { Attempts = 8 });

app.Run();
