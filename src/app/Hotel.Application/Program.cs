using Hotel.Business;
using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using Repository;
using System;
using System.Collections;
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
            var business = new IRoomBusiness(new RoomRepository());
            if (query != null)
                Console.WriteLine($"{query.Id}\t{query.Guid}\t{query.Locked}\t{query.Empty}\t{query.Price}\t{query.Type} ");
            else
                Console.WriteLine("Query é nulo.");
            ClientRepository clientRepository = new ClientRepository();
            var client = new Client("AAA", "AAA", "AAA", "AAA");
            var client1 = new Client("BBB", "BBB", "BBB", "BBB");
            var client2 = new Client("CCC", "CCC", "CCC", "CCC");
            var client3 = new Client("DDD", "DDD", "DDD", "DDD");
            clientRepository.Insert(client);
            clientRepository.Insert(client1);
            clientRepository.Insert(client2);
            var lclients = clientRepository.GetList();
            var query1 = (from lclient in lclients
                          where lclient.Nome == "CCC"
                          select lclient).SingleOrDefault();
            var query2 = lclients.Where(x => x.Nome == "CCC").SingleOrDefault();
            query2 = client3;
            Console.WriteLine($"Count: {lclients.Count}");

            foreach (var c in lclients)
            {
                Console.WriteLine($"{c.Id}\t{c.Guid}\t{c.Nome}\t{c.Telefone}\t{c.Email}");
            }
        }
    }
}
