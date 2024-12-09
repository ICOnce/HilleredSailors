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
        [BindProperty]
        public Booking Booking { get; set; }
        public MakeBookingModel(IBoatRepository BRepo, IBookingRepository BORepo) { 
            boatRepository = BRepo;
            bookingRepository = BORepo;
        }
        public void OnGet(string SailNumber)
        {
            Booking = new Booking(boatRepository.GetBoat(SailNumber));

        }

        public IActionResult OnPost() {
            if (bookingRepository.BookingPossible(Booking)) { 
                
            }
        }
    }
}
