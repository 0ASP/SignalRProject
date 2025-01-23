using SignalR.Bussiness.Abstract;
using SignalR.DataAccess.Abstract;
using SignalR.Entity.Entities;

namespace SignalR.Bussiness.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingService;

        public BookingManager(IBookingDal bookingService)
        {
            _bookingService = bookingService;
        }

        public void TAdd(Booking entity)
        {
            _bookingService.Add(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingService.Delete(entity);
        }

        public Booking TGetById(int id)
        {
            return _bookingService.GetById(id);
        }

        public List<Booking> TGetListAll()
        {
            return _bookingService.GetListAll();
        }

        public void TUpdate(Booking entity)
        {
            _bookingService.Update(entity);
        }
    }
}
