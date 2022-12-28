using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SampleAPIProject;
using SampleAPIProject.Data;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SampleAPIProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SampleAPIProjectContext") ?? throw new InvalidOperationException("Connection string 'SampleAPIProjectContext' not found.")));

// Add services to the container.

var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

builder.Services.Configure<JWTSettings>(
    builder.Configuration.GetSection("JWTSettings"));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sample  API Project with Token Generation", Version = "v1" });


    c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
