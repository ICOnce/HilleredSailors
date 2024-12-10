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

        [BindProperty]
        public string SailNumber { get; set; }
      
        public MakeBookingModel(IBoatRepository BRepo, IBookingRepository BORepo) {
            if (Booking == null)
            {
                Booking = new Booking();
            }
            boatRepository = BRepo;
            bookingRepository = BORepo;
        }

        public void OnGet(string sailNumber)
        {
            SailNumber = sailNumber;
            Booking.AddBoat(boatRepository.GetBoat(SailNumber));
            Booking.Boat = b;
            Booking.AddBoat(boatRepository.GetBoat(SailNumber));
            Booking.Boat = b;
            Booking.AddBoat(boatRepository.GetBoat(SailNumber));
            IBoat b = boatRepository.GetBoat(SailNumber);
            Booking.AddBoat(boatRepository.GetBoat(SailNumber));
            Booking.Boat = b;
            Booking.Boat = b;
        }

        public IActionResult OnPost() {
            if (bookingRepository.BookingPossible(Booking)) {
                bookingRepository.ABooking(Booking);
                return Redirect("/Index");
            }
            SailNumber = Booking.Boat.SailNumber;
            return Redirect("MakeBooking");
        }
    }
}
