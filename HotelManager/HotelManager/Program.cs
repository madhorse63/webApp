using HotelManager.Data.Stores.Room;
using HotelManager.Domain.Services.Room;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IRoomStore, RoomStore>();
builder.Services.AddSingleton<IRoomService, RoomService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
