using _1.Domain.Fruits;
using _2.Application;
using _2.Application.Models;
using _2.Application.Validators;
using _4.Presentation.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using FluentValidation;
using _4.Presentation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//H�r sker DI
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IFruitPressService, FruitPressService>();
builder.Services.AddTransient<IFruit, Fruit>();
builder.Services.AddSingleton<IJuiceMenu, JuiceMenu>();
builder.Services.AddScoped<IValidator<OrderModel>, OrderValidator>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
