using Hotel.Services;

namespace HotelTahoe.App.Interfaces
{
    public interface IApp
    {
        BookingService BookingService { get; }
        ClientService ClientService { get; }
        RoomService RoomService { get; }
    }
}
