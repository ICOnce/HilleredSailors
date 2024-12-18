using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Bookings
{
    public class DeleteBookingModel : PageModel
    {
        #region Instances
        public IBookingRepository _repo;
        #endregion

        #region Propeties
        [BindProperty]
        public Booking Booking { get; set; }
        public Member Member { get; set; }
        #endregion

        #region Methods
        public DeleteBookingModel(IBookingRepository bookingRepository, Member m)
        {
            Member = m;
            _repo = bookingRepository;
        }
        public void OnGet(int deleteBooking)
        {
            Booking = _repo.GetBookingByID(deleteBooking);
        }
        /*
        public void OnGet(IMember deleteMember)
        {
            Booking = _repo.GetBookingByMember(deleteMember);
        }
        */
        public IActionResult OnPost()
        {
            _repo.DeleteBooking(Booking.Id);
            return RedirectToPage("ShowBookings");
        }
        #endregion
    }
}
