using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Tools
{
    public class ReturnToolsModel : PageModel
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
        public ReturnToolsModel(IEquipmentRepository EquipRepo, Member member)
        {
            _equipmentRepository = EquipRepo;
            Member = member;
        }
        #endregion

        #region Methods
        public void OnGet(int id)
        {
            Equipment = _equipmentRepository.GetEquipment(id);
        }
        public IActionResult OnPost(int id)
        {
            _equipmentRepository.ReturnEquipment(id);
            return Redirect("ShowTools");
        }
        #endregion
    }
}
