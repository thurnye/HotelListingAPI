using Serilog;

using Microsoft.EntityFrameworkCore;
using HotelListingAPI.DataAccess.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//connection string to Db
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<HotelListingDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors Services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        b => b.AllowAnyHeader()
            .AllowAnyOrigin()
             .AllowAnyMethod());
});

//Add Serilog
builder.Host.UseSerilog((ctx, lc) =>
    lc.WriteTo
        .Console()
        .ReadFrom
        .Configuration(ctx.Configuration));

var app = builder.Build();

//This will log in the type of request that comes in like GET other data
app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");  //use the cors

app.UseAuthorization();

app.MapControllers();

app.Run();

