using RestSharp;
using System.Text.Json;
using Svc.SalesTaxApi;
using RestSharp.Serializers.Json;
using Lib.SalesTaxApi.Interfaces;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

//Enforcing lower case URls by convention
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ITaxCalculator, TaxJarCalculator>();
builder.Services.AddTransient<ITaxService, TaxJarService>();

//Services registration
builder.Services.AddSingleton<RestClient>(s =>
{
    var client = new RestClient("https://api.taxjar.com/v2");
    client.UseSystemTextJson(); 
    return client;

 });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

