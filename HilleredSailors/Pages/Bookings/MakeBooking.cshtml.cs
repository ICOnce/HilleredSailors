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
        public Booking booking { get; set; }
        public MakeBookingModel(IBoatRepository BRepo, IBookingRepository BORepo) { 
            boatRepository = BRepo;
            bookingRepository = BORepo;
        }
        public void OnGet(string SailNumber)
        {
        }
    }
}
