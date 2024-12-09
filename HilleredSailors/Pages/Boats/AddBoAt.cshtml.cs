using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class AddBoAtModel : PageModel
    {
        public IBoatRepository BoatRepository;
        [BindProperty]
        public Boat boat { get; set; }

        public AddBoAtModel(IBoatRepository bRepo) { 
            BoatRepository = bRepo;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost() {
            BoatRepository.AddBoat(boat);
            return RedirectToPage("/Index");
        }
    }
}
