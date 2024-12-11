using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;

namespace HilleredSailors.Pages.Boats
{
    public class ShowBoatsModel : PageModel
    {
        public IBoatRepository BRepo;
        public IBookingRepository BookingRepo;

        public List<IBoat> BoatList;

        [BindProperty]
        public DateTime StartTime { get; set; }

        [BindProperty]
        public DateTime EndTime { get; set; }


        public ShowBoatsModel(IBoatRepository br, IBookingRepository bookingRepo) { 
            BRepo = br;
            BookingRepo = bookingRepo;
            BoatList = new List<IBoat>();
            BoatList = BRepo.GetAll();
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            BoatList = new List<IBoat>();
            Booking booking = new Booking();
            booking.StartTime = StartTime;
            booking.EndTime = EndTime;
            foreach (Boat b in BRepo.GetAll())
            {
                booking.AddBoat(b);
                booking.Boat = b;
                if (!BookingRepo.BookingPossible(booking)) BoatList.Remove(b);
            }
            return Page();
        }
    }
}
