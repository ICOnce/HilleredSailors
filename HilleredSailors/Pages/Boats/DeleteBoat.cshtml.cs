using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class DeleteBoatModel : PageModel
    {
        #region Instances
        private IBoatRepository _boatRepository;
        #endregion

        #region Properties
        [BindProperty]
        public Boat Boat { get; set; }
        #endregion

        #region Constructor
        public DeleteBoatModel(IBoatRepository BRepo) { 
            _boatRepository = BRepo;
        }
        #endregion

        #region Methods
        public void OnGet(string deleteSN)
        {
            Boat = _boatRepository.GetBoat(deleteSN);
        }
        public IActionResult OnPost() {
            _boatRepository.DeleteBoat(Boat.SailNumber);
            return Redirect("ShowBoats");
        }
        #endregion
    }
}
