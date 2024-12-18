using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Bookings
{
    public class EditBookingModel : PageModel
    {
        public Member Member { get; set; }

        public EditBookingModel(Member m) { 
            Member = m;
        }
        public void OnGet()
        {
        }
    }
}
