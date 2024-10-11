﻿using HotelManager.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelManager.Core.DTOs.RoomDTO
{
    public class RoomDTO
    {
        public RoomDTO(int id, int number, decimal price, RoomType type)
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
