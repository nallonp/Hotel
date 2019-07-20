using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Room> rooms = new List<Room>();
            List<Room> rooms2 = new List<Room>();
            DateTime date = DateTime.Today;
            var room = new Room
            {
                Active = true,
                Occupied = true,
                Type = ERoomType.Luxo
            };
            var room2 = new Room
            {
                Active = true,
                Occupied = true,
                Type = ERoomType.Standart
            };
            var room3 = new Room
            {
                Active = true,
                Occupied = true,
                Type = ERoomType.Single
            };

            room2.Type = ERoomType.Single;
            room3.Type = ERoomType.Standart;
            rooms.Add(room);
            rooms.Add(room2);
            rooms2.Add(room3);
            //var query = from r in rooms
            //group r by r.Type;,
            rooms.AddRange(rooms2);
            foreach (var s in rooms)
            {
                Console.WriteLine($"Type: {s.Type} Guid: {s.Guid}");
            }
            //foreach (var item in query)
            //{
                //Console.WriteLine($"Item: {item.Key}");
            //}
                     
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
        }
    }
}
