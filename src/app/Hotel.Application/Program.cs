using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using Repository;
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
            var room1 = new Room(270.00, true, false, ERoomType.Standart);
            var room2 = new Room(310.00, true, false, ERoomType.Single);
            var room3 = new Room(470.00, true, true, ERoomType.Luxo);
            RoomRepository roomRepository = new RoomRepository();
            roomRepository.Insert(room1);
            roomRepository.Insert(room2);
            roomRepository.Insert(room3);
            var query = roomRepository.SelectAvailableRoom();
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Id}\t{item.Guid}\t{item.Active}\t{item.Empty}\t{item.Price}\t{item.Type} ");
            //}
            if (query != null)
                Console.WriteLine($"{query.Id}\t{query.Guid}\t{query.Active}\t{query.Empty}\t{query.Price}\t{query.Type} ");
            else
                Console.WriteLine("Query é nulo.");
            ClientRepository clientRepository = new ClientRepository();
            var client = new Client("AAA", "AAA", "AAA", "AAA");
            var client1 = new Client("BBB", "BBB", "BBB", "BBB");
            var client2 = new Client("CCC", "BBB", "BBB", "BBB");
            clientRepository.Insert(client);
            clientRepository.Insert(client1);
            clientRepository.Insert(client2);
            var lclient = clientRepository.GetList();
            Console.WriteLine($"Count: {lclient.Count}");
            foreach (var c in lclient)
            {
                Console.WriteLine($"{c.Id}\t{c.Guid}\t{c.Nome}\t{c.Telefone}\t{c.Email}");
            }
        }
    }
}
