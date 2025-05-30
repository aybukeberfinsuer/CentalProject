using Cental.BusinessLayer.Abstract;
using Cental.BusinessLayer.Concrete;
using Cental.BusinessLayer.Extensions;
using Cental.BusinessLayer.Validators;
using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Concrete;
using Cental.DataAccessLayer.Context;
using Cental.EntityLayer.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//about service g�rd���n zaman aboutmanager s�n�f�ndan bir nesne �rne�i al ve i�lemi onunla yap.

builder.Services.AddDbContext<CentalContext>();
builder.Services.AddIdentity<AppUser, AppRole>(cfg =>
{
	cfg.User.RequireUniqueEmail = true;
})
												.AddEntityFrameworkStores<CentalContext>()
												.AddErrorDescriber<CustomErrorDescriber>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddServiceRegistrations();

builder.Services.AddFluentValidationAutoValidation()
	.AddFluentValidationClientsideAdapters()
	.AddValidatorsFromAssemblyContaining<BrandValidator>();


builder.Services.AddControllersWithViews(option => {
	option.Filters.Add(new AuthorizeFilter());
	});
builder.Services.ConfigureApplicationCookie(config =>
{
	config.LoginPath = "/Login/Index";
	config.LogoutPath = "/Login/Logout";
});
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
