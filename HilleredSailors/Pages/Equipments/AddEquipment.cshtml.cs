using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Equipments
{
    public class AddEquipmentModel : PageModel
    {
        #region Instances
        private EquipmentRepository _equipmentRepository;
        #endregion

        #region Properties
        [BindProperty]
        public Equipment Equipment { get; set; }
        [BindProperty]
        public Equipment Description { get; set; }
        #endregion

        #region Constructor
        public AddEquipmentModel(EquipmentRepository equipment)
        {
            _equipmentRepository = equipment;
        }
        #endregion

        #region Methods
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _equipmentRepository.AddEquipment(Equipment);
            return RedirectToPage("ShowEquipment");
        }
        #endregion
    }
}
