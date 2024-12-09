using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Bookings
{
    public class ShowBookingsModel : PageModel
    {
        private IBookingRepository _bookingRepo;

        #region View Model
        public List<IBooking> Bookings { get; private set; }
        #endregion

        public ShowBookingsModel(IBookingRepository bookingRepository)
        {
            _bookingRepo = bookingRepository;
        }
        public void OnGet()
        {
            Bookings = _bookingRepo.GetAll();
        }
    }
}
