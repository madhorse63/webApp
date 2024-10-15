using HotelManager.Data;
using HotelManager.Data.Stores.RoomStore;
using HotelManager.Domain.Services.Room;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IRoomStore, RoomStore>();
builder.Services.AddScoped<IRoomService, RoomService>();

builder.Services.AddDbContext<HotelManagerDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
