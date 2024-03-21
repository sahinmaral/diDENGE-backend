using Core.CrossCuttingConcerns.Exceptions;
using diDENGE.Application;
using diDENGE.Persistance;
using diDENGE.Presentation;
using Core.Security;
using diDENGE.Persistance.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true)
    .AddApplicationPart(diDENGE.Presentation.AssemblyReference.Assembly);

builder.Services
    .AddPersistance(builder.Configuration)
    .AddApplication()
    .AddPresentation();

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

app.MapControllers();


app.UseAuthentication();
app.UseAuthorization();

app.Run();
