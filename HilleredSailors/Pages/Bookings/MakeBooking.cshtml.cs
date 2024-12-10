using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Bookings
{
    public class MakeBookingModel : PageModel
    {
        public IBoatRepository boatRepository;
        public IBookingRepository bookingRepository;
        public string Scuffed { get; set; }
        [BindProperty]
        public Booking Booking { get; set; }
      
        public MakeBookingModel(IBoatRepository BRepo, IBookingRepository BORepo) { 
            boatRepository = BRepo;
            bookingRepository = BORepo;
        }
        public void OnGet(string SailNumber)
        {
            Scuffed = SailNumber;
            
        }

        public IActionResult OnPost() {
            Booking = new Booking();
            Booking.Boat = (boatRepository.GetBoat(Scuffed));
            if (bookingRepository.BookingPossible(Booking)) {
                bookingRepository.ABooking(Booking);
                return Redirect("/Index");
            }
            return Redirect("MakeBooking");
        }
    }
}
