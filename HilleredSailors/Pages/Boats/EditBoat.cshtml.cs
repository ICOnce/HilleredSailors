using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class EditBoatModel : PageModel
    {
        #region Instances
        private IBoatRepository _boatRepository;
        #endregion
        public Member Member { get; set; }
        #region Properties
        [BindProperty]
        public Boat Boat { get; set; }
        #endregion

        #region Constructor
        public EditBoatModel(IBoatRepository BRepo ,Member m)
        {
            Member = m;
            _boatRepository = BRepo;
        }
        #endregion

        #region Methods
        public void OnGet(string editSN)
        {
            Boat = _boatRepository.GetBoat(editSN);
        }
        public IActionResult OnPost()
        {
            _boatRepository.UpdateBoat(Boat,Boat.SailNumber);
            return Redirect("ShowBoats");
        }
        #endregion
    }
}
