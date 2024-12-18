using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Bookings
{
    public class MakeBookingModel : PageModel
    {
        #region Instances
        private int _id = 0;
        private IBoatRepository _boatRepository;
        private IBookingRepository _bookingRepository;
        #endregion

        #region Properties
        public bool ValidBook { get; private set; } = true;

        [BindProperty]
        public Booking Booking { get; set; }

        [BindProperty]
        public string SailNumber { get; set; }

        [BindProperty]
        public string StartTime { get; set; }

        [BindProperty]
        public string EndTime { get; set; }

        public Member Member { get; set; }
        #endregion

        #region Constructor
        public MakeBookingModel(IBoatRepository BRepo, IBookingRepository BORepo, Member m) {
            Member = m;
            _id++;
            Booking = new Booking();
            _boatRepository = BRepo;
            _bookingRepository = BORepo;
        }
        #endregion
        #region Methods
        public void OnGet(string endTime, string sailNumber, string startTime)
        {
            SailNumber = sailNumber;
            StartTime = startTime;
            EndTime = endTime;
        }
        public IActionResult OnPost() {
            Boat b = _boatRepository.GetBoat(SailNumber);
            Booking.AddBoat(_boatRepository.GetBoat(SailNumber));
            Booking.Boat = b;
            Booking.StartTime = DateTime.Parse(StartTime);
            Booking.EndTime = DateTime.Parse(EndTime);
            Booking.Booker = Member;
            if (_bookingRepository.BookingPossible(Booking)) {
                _bookingRepository.ABooking(Booking);
                ValidBook = true;
                return Redirect("ShowBookings");
            }
            ValidBook = false;
            return Page();
        }
        #endregion
    }
}
