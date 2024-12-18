using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Equipments
{
    public class ShowEquipmentModel : PageModel
    {
        #region Instances
        private EquipmentRepository _equipmentRepository;
        #endregion

        #region Properties
        [BindProperty]
        public Equipment Equipment { get; set; }
        #endregion

        #region Constructor
        public ShowEquipmentModel(EquipmentRepository equipRepo)
        {
            _equipmentRepository = equipRepo;
        }
        #endregion

        #region Methods
        public void OnGet(int id)
        {
            Equipment = _equipmentRepository.GetEquipment(id);
        }
        public IActionResult OnPost()
        {
            _equipmentRepository.DeleteEquipment(Equipment.Id);
            return Redirect("ShowEquipment");
        }
        #endregion
    }
}
