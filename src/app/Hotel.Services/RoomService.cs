using Hotel.Business;

namespace Hotel.Services.Interfaces
{
    public class RoomService : IRoomService
    {
        private readonly IRoomBusiness _roomBusiness;
        public RoomService(IRoomBusiness roomBusiness)
        {
            _roomBusiness = roomBusiness;
        }
    }
}