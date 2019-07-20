using Hotel.Business;

namespace Hotel.Services
{
    public class RoomService
    {
        private readonly RoomBusiness _roomBusiness;
        public RoomService(RoomBusiness business)
        {
            _roomBusiness = business;
        }
    }
}