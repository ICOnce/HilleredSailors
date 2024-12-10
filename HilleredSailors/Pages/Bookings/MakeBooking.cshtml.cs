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

        public bool ValidBook { get; private set; } = true;
        [BindProperty]
        public Booking Booking { get; set; }

        [BindProperty]
        public string SailNumber { get; set; }
      
        public MakeBookingModel(IBoatRepository BRepo, IBookingRepository BORepo) {
            boatRepository = BRepo;
            bookingRepository = BORepo;
        }

        public void OnGet(string sailNumber)
        {
            SailNumber = sailNumber;
        }

        public IActionResult OnPost() {
            IBoat b = boatRepository.GetBoat(SailNumber);
            Booking.AddBoat(boatRepository.GetBoat(SailNumber));
            Booking.Boat = b;
            if (bookingRepository.BookingPossible(Booking)) {
                bookingRepository.ABooking(Booking);
                ValidBook = true;
                return Redirect("/Index");
            }
            ValidBook = false;
            return Page();
        }
        #endregion
    }
}
