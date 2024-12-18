using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Tools
{
    public class DeleteToolsModel : PageModel
    {
        #region Instances
        private IEquipmentRepository _equipmentRepository;
        #endregion

        #region Properties
        [BindProperty]
        public Equipment Equipment { get; set; }
        public Member Member { get; set; }
        #endregion

        #region Constructor
        public DeleteToolsModel(IEquipmentRepository equipRepo, Member member)
        {
            _equipmentRepository = equipRepo;
            Member = member;
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
            return Redirect("ShowTools");
        }
        #endregion
    }
}
