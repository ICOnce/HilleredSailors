using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class EditBoatModel : PageModel
    {
        private IBoatRepository _boatRepo;

        [BindProperty]
        public Boat Boat { get; set; }
        public EditBoatModel(IBoatRepository BRepo) {
            _boatRepo = BRepo;
            Boat = new Boat();
        }
        public void OnGet(string SailNumber)
        {

            Boat= (Boat)_boatRepo.GetBoat(SailNumber);
        }

        public IActionResult OnPost() {
            _boatRepo.UpdateBoat(Boat, Boat.SailNumber); 
            return Redirect("ShowBoats");
        }
    }
}
