using Microsoft.EntityFrameworkCore;
using user.infrastructure;
using user.application;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddDbContext<ViewallDbContext>(opts =>
{
    opts.EnableDetailedErrors();
    opts.UseNpgsql(builder.Configuration.GetConnectionString("viewall_conn"));
});
builder.Services.ConfigureUserApplicationServices();
builder.Services.ConfigureUserPersistenceServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
