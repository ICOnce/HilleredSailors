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

        [BindProperty]
        public string StartTime { get; set; }

        [BindProperty]
        public string EndTime { get; set; }
      
        public MakeBookingModel(IBoatRepository BRepo, IBookingRepository BORepo) {
            Booking = new Booking();
            boatRepository = BRepo;
            bookingRepository = BORepo;
        }

        public void OnGet(string endTime, string sailNumber, string startTime)
        {
            SailNumber = sailNumber;
            StartTime = startTime;
            EndTime = endTime;
        }

        public IActionResult OnPost() {
            IBoat b = boatRepository.GetBoat(SailNumber);
            Booking.AddBoat(boatRepository.GetBoat(SailNumber));
            Booking.Boat = b;
            Booking.StartTime = DateTime.Parse(StartTime);
            Booking.EndTime = DateTime.Parse(EndTime);
            if (bookingRepository.BookingPossible(Booking)) {
                bookingRepository.ABooking(Booking);
                ValidBook = true;
                return Redirect("/Index");
            }
            ValidBook = false;
            return Page();
        }
        
    }
}
