using Hotel.Business;

namespace Hotel.Services.Interfaces
{
    public class RoomService : IRoomService
    {
        private readonly RoomBusiness _roomBusiness;
        public RoomService(RoomBusiness business)
        {
            _roomBusiness = business;
        }
    }
}