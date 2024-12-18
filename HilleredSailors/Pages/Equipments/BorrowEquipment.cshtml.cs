using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Equipment
{
    public class BorrowEquipmentModel : PageModel
    {
        #region Instances
        private IEquipmentRepository _equipmentRepository;
        #endregion

        #region Properties
        [BindProperty]
        public Equipment Equipment { get; set; }
        #endregion

        #region Constructor
        public BorrowEquipmentModel(IEquipmentRepository EquipRepo)
        {
            _equipmentRepository = EquipRepo;
        }
        #endregion

        #region Methods
        public void OnGet(int id)
        {
            Equipment = _equipmentRepository.GetEquipment(id);
        }
        public IActionResult OnPost()
        {
            _equipmentRepository.BorrowEquipment(Equipment, Equipment.Id);
            return Redirect("ShowEquipment");
        }
        #endregion
    }
}
