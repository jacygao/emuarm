using Emu.Controllers.Compute.ImageController;
using Emu.Middlewares;
using Emu.Services.Common;
using Emu.Services.Image;
using Scalar.AspNetCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add Azure Storage
// Bind the AzureStorage section in appsettings.json to the AzureStorageOptions class
builder.Services.Configure<AzureStorageOptions>(builder.Configuration.GetSection("AzureStorage"));

// Add AzureBlobStorageService to the DI container
builder.Services.AddSingleton<IStorageService, AzureBlobStorageService>();

// Add Domain Services
builder.Services.AddSingleton<IImageService, ImageService>();

builder.Services.AddScoped<ImageController.IImagesController, ImageControllerImpl>();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        // Required for supporting enum conversion
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Add Custom Middlewares
app.UseMiddleware<CommonExceptionHandlerMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
