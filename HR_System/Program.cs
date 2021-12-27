using HR_System.Models;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

builder.Services.AddDbContext<HrSysContext>(option => option.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("hrcon")));


var app = builder.Build();
//builder.Services.AddSession(Option => {
//    Option.IdleTimeout = TimeSpan.FromMinutes(15);
//    });


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Error/{statusCode}");
    //app.UseStatusCodePagesWithRedirects("/Error/{0}");

    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
//else
//{
//    app.UseDeveloperExceptionPage();
//}
app.UseExceptionHandler("/Error/500");
//app.UseExceptionHandler("/Error/{statusCode}");
app.UseStatusCodePagesWithRedirects("/Error/{statusCode}");
app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=operation}/{action=login}/{id?}");

app.Run();
