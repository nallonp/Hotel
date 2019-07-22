using Hotel.Business;
using Hotel.Services;
using HotelTahoe.App.Interfaces;
using Repository;

namespace HotelTahoe.App
{
    public class App : IApp
    {
        public BookingService BookingService { get; }
        public ClientService ClientService { get; }
        public RoomService RoomService { get; }
        public App()
        {
            BookingService bookingService;
            ClientService clientService;
            RoomService roomService;
            LoadDependences(out bookingService, 
                out clientService, 
                out roomService);
        }
        public void Run()
        {

        }

        private void LoadDependences(out BookingService bookingService, out ClientService clientService, out RoomService roomService)
        {
            bookingService = new BookingService(new BookingBusiness(new BookingRepository()));
            clientService = new ClientService(new ClientBusiness(new ClientRepository()));
            roomService = new RoomService(new RoomBusiness(new RoomRepository()));
        }
    }
}
