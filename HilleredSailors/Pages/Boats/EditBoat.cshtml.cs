using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class EditBoatModel : PageModel
    {
        private IBoatRepository _boatRepository;
        [BindProperty]
        public Boat Boat { get; set; }
        public EditBoatModel(IBoatRepository BRepo)
        {
            _boatRepository = BRepo;
        }
        public void OnGet(string SailNumber)
        {
            Boat = (Boat)_boatRepository.GetBoat(SailNumber);
        }

        public IActionResult OnPost()
        {
            
            _boatRepository.UpdateBoat(Boat,Boat.SailNumber);
            return Redirect("ShowBoats");
        }
    }
}
