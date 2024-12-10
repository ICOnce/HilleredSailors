using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class DeleteBoatModel : PageModel
    {
        private IBoatRepository _boatRepository;
        [BindProperty]
        public Boat Boat { get; set; }
        public DeleteBoatModel(IBoatRepository BRepo) { 
            _boatRepository = BRepo;
        }
        public void OnGet(string SailNumber)
        {
            Boat=(Boat)_boatRepository.GetBoat(SailNumber);
        }

        public IActionResult OnPost() {
            _boatRepository.DeleteBoat(Boat.SailNumber);
            return Redirect("ShowBoats");
        }

        
    }
}
