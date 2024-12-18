using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using System.Collections.Generic;

namespace HilleredSailors.Pages.Boats
{
    public class ShowBoatsModel : PageModel
    {
        #region Instances
        public IBoatRepository BRepo;
        public IBookingRepository BookingRepo;
        public List<Boat> BoatList;
        #endregion
        public Member Member { get; set; }
        #region Properties
        [BindProperty]
        public DateTime StartTime { get; set; }

        [BindProperty]
        public DateTime EndTime { get; set; }
        #endregion

        #region Constructor
        public ShowBoatsModel(IBoatRepository br, IBookingRepository bookingRepo, Member m) { 
            Member = m;
            BRepo = br;
            BookingRepo = bookingRepo;
            BoatList = BRepo.GetAll();
        }
        #endregion

        #region Methods
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            BoatList = BRepo.GetAll();
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
        #endregion
    }
}
