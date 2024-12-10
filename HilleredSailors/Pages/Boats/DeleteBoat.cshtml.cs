using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class DeleteBoatModel : PageModel
    {
        private IBoatRepository _boatRepo;

        [BindProperty]
        public Boat Boat { get; set; }
        public DeleteBoatModel(IBoatRepository BRepo)
        {
            _boatRepo = BRepo;
            Boat = new Boat();
        }
        public void OnGet(string SailNumber)
        {

            Boat = (Boat)_boatRepo.GetBoat(SailNumber);
        }

        public IActionResult OnPost()
        {
            _boatRepo.DeleteBoat(Boat.SailNumber);
            return Redirect("ShowBoats");
        }
    }
}
