using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class AddBoAtModel : PageModel
    {
        #region Instances
        public IBoatRepository BoatRepository;
        #endregion

        #region Properties
        [BindProperty]
        public Boat boat { get; set; }
        #endregion

        #region Constructor
        public AddBoAtModel(IBoatRepository bRepo) 
        { 
            BoatRepository = bRepo;
        }
        #endregion

        #region Methods
        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            boat.Log = new Log();
            BoatRepository.AddBoat(boat);

            return RedirectToPage("ShowBoats");
        }
        #endregion
    }
}
