using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using Repository;
using Xunit;

namespace Hotel.RepositoryTests
{
    public class RoomRepositoryTest
    {
        RoomRepository roomRepository = new RoomRepository();
        [Fact]
        public void SelectVacantRoomsTest()
        {
            Room a = new Room() { Active = true, Occupied = true, Type = ERoomType.Luxo };
            Room b = new Room() { Active = true, Occupied = true, Type = ERoomType.Luxo };
            Room c = new Room() { Active = true, Occupied = false, Type = ERoomType.Luxo };
            var r = roomRepository.SelectVacantRooms();
        }
    }
}
