using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Equipments
{
    public class DeleteEquipmentModel : PageModel
    {
        #region Instances
        private EquipmentRepository _equipmentRepository;
        #endregion

        #region Properties
        [BindProperty]
        public Equipment Equipment { get; set; }
        public Member Member { get; set; }
        #endregion

        #region Constructor
        public DeleteBookingModel(IBoatRepository BRepo, Member m)
        {
            Member = m;
            _boatRepository = BRepo;
        }
        #endregion

        #region Methods
        public void OnGet(string deleteSN)
        {
            Boat = _boatRepository.GetBoat(deleteSN);
        }
        public IActionResult OnPost()
        {
            _boatRepository.DeleteBoat(Boat.SailNumber);
            return Redirect("ShowBoats");
        }
        #endregion
    }
}
