using HotelManager.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelManager.Data.Entites.Room
{
    public class Room
    {
        public Room(int id, int number, decimal price, RoomType type)
        {
            Id = id;
            Number = number;
            Price = price;
            Type = type;
        }
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public RoomType Type { get; set; }
    }
}
