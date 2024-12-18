using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Objects;
using BoatLibrary.Interfaces;
namespace HilleredSailors.Pages
{
    public class IndexModel : PageModel
    {
        private IBookingRepository _bookingRepository;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Member Member { get; set; }
        public List<Booking> BookingList { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, IBookingRepository bookingRepository, Member m)
        {
            _bookingRepository = bookingRepository;
            _logger = logger;
            BookingList = new List<Booking>();
            Member = m;
        }

        public void OnGet()
        {
            foreach(Booking b in _bookingRepository.GetAll())
            {
                if (b.StartTime.Date == DateTime.Now.Date || (b.EndTime < DateTime.Now && !b.Returned))
                {
                    BookingList.Add(b);
                }
            }
        }

        public IActionResult OnPost(int id)
        {
            _bookingRepository.GetBookingByID(id).Returned = true;
            OnGet();
            return Page();
        }
    }
}
