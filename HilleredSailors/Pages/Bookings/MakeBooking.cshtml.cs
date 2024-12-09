using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Bookings
{
    public class MakeBookingModel : PageModel
    {
        #region Instances
        private IBoatRepository _boatRepository;
        private IBookingRepository _bookingRepository;
        #endregion

        #region Properties
        [BindProperty]
        public Booking Booking { get; set; }
        #endregion

        #region Constructor
        public MakeBookingModel(IBoatRepository BRepo, IBookingRepository BORepo) 
        { 
            _boatRepository = BRepo;
            _bookingRepository = BORepo;
        }
        #endregion

        #region Methods
        public void OnGet(string SailNumber)
        {
            Booking = new Booking(_boatRepository.GetBoat(SailNumber));

        }
        public IActionResult OnPost() 
        {
            if (_bookingRepository.BookingPossible(Booking)) 
            {
                return null;
            }
            return null;
        }
        #endregion
    }
}
