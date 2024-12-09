using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Bookings
{
    public class DeleteBookingModel : PageModel
    {
        #region Instances
        private IBookingRepository _repo;
        #endregion

        #region Propeties
        [BindProperty]
        public IBooking Booking { get; set; }
        #endregion

        #region Methods
        public DeleteBookingModel(IBookingRepository bookingRepository)
        {
            _repo = bookingRepository;
        }
        public void OnGet(IMember deleteMember)
        {
            Booking = _repo.GetBookingByMember(deleteMember);
        }
        public IActionResult OnPost()
        {
            _repo.DeleteBooking(Booking);
            return RedirectToPage("ShowBookings");
        }
        #endregion
    }
}
