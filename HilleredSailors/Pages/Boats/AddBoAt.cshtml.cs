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
        public Member Member { get; set; }

        #region Properties
        [BindProperty]
        public Boat boat { get; set; }
        #endregion

        #region Constructor
        public AddBoAtModel(IBoatRepository bRepo, Member m) 
        { 
            Member = m;
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
