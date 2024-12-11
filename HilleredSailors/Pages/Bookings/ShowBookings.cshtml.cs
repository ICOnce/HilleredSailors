using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Bookings
{
    public class ShowBookingsModel : PageModel
    {
        #region Instances
        private IBookingRepository _bookingRepo;
        #endregion

        #region View Model
        public List<IBooking> Bookings { get; private set; }
        #endregion

        #region Constructor
        public ShowBookingsModel(IBookingRepository bookingRepository)
        {
            _bookingRepo = bookingRepository;
        }
        #endregion

        #region Methods
        public void OnGet()
        {
            Bookings = _bookingRepo.GetAll();
        }
        #endregion
    }
}
