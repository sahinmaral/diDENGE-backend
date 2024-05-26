using Core.CrossCuttingConcerns.Exceptions;
using diDENGE.Application;
using diDENGE.Persistance;
using diDENGE.Presentation;
using Core.Security;
using diDENGE.Infrastructure;
using diDENGE.Persistance.Context;
using diDENGE.WebAPI.Extensions;
using DotNetEnv.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddDotNetEnv();

builder.ConfigureEnvironmentVariables();

builder.Services
    .AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true)
    .AddApplicationPart(diDENGE.Presentation.AssemblyReference.Assembly);

builder.Services
    .AddPersistanceServices(builder.Configuration)
    .AddInfrastructureServices()
    .AddApplicationServices()
    .AddPresentationServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("MyOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:8081")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddSecurityServices<AppDbContext>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<AppDbContext>();
    try
    {
        dbContext.Database.Migrate();
    }
    catch (Exception ex)
    {
        throw new Exception("Error applying database migrations.", ex);
    }
}

app.UseCors("MyOrigin");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt => { opt.DisplayRequestDuration(); opt.SwaggerEndpoint("/swagger/v1/swagger.json", "diDENGE"); });
}

if (app.Environment.IsProduction())
    app.ConfigureCustomExceptionMiddleware();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
