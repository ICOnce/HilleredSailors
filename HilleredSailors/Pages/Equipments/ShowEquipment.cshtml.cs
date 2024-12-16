using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Equipments
{
    public class ShowEquipmentModel : PageModel
    {
        private IEquipmentRepository _equipmentRepository;

        public List<Equipment> Tools;

        public ShowEquipmentModel(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        public void OnGet()
        {
            Tools = _equipmentRepository.GetAll();
        }
    }
}
