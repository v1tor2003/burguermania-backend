using BurguerMania.Domain.Interfaces;
using BurguerMania.Application;
using BurguerMania.Application.Services;
using BurguerMania.Infrastructure;
using BurguerMania.Infrastructure.Context;
using BurguerMania.Infrastructure.Repositories;
using BurguerMania.Presentation.Middlewares;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureApplication();
builder.Services.ConfigureInfrastructure(builder.Configuration);

builder.Services.AddScoped(typeof(IRepository<,>), typeof(BaseRepository<,>));
builder.Services.AddScoped(typeof(IService<,>), typeof(BaseService<,>));

// Register Services

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var uploads = GetUploadsFolder();

if(!Directory.Exists(uploads))
{
    Directory.CreateDirectory(uploads);
}

CreateDatabase(app);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseAuthorization();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(uploads),
    RequestPath = "/uploads"
});

app.MapControllers();

app.Run();

static void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var appdbContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    appdbContext?.Database.EnsureCreated();
}

static string GetInfrastructurePath()
{
    var projectPath = Directory.GetCurrentDirectory().Split("\\BurguerMania.Presentation")[0];
    return Path.Combine(projectPath, "BurguerMania.Infrastructure");
}

static string GetUploadsFolder()
{
    var infrastructurePath = GetInfrastructurePath();
    return Path.Combine(infrastructurePath, "Uploads");
}