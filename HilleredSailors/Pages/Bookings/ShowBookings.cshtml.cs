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
        public List<Booking> Bookings { get; private set; }
        public Member Member { get; set; }
        #endregion

        #region Constructor
        public ShowBookingsModel(IBookingRepository bookingRepository, Member m)
        {
            Member = m;
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
