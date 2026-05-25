using Microsoft.EntityFrameworkCore;
using Employee.api.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EmployeeDbContext>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("empConn")));




var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
