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
        private IEquipmentRepository _equipmentRepository;
        public List<Equipment> Equipment { get; private set; }
        #endregion

        #region Properties
        
        #endregion

        #region Constructor
        public ShowEquipmentModel(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        #endregion

        #region Methods
        public void OnGet()
        {
            Equipment = _equipmentRepository.GetAll();
        }
        
        #endregion
    }
}
