using Microsoft.EntityFrameworkCore;
using personalfinancetrackerbackend.DatabaseInteraction;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(option=> {
    option.ReturnHttpNotAcceptable = true;
 });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataInteraction>(option =>
{
    try
    {
        var connectionString = builder.Configuration.GetSection("ConnectionStrings")["databaseConnection"];
        option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
    catch(Exception e)
    {
        Console.WriteLine(e);
    }
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
