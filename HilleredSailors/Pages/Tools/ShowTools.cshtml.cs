using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Tools
{
    public class ShowToolsModel : PageModel
    {
        #region Instances
        private IEquipmentRepository _equipmentRepository;
        #endregion

        #region Properties
        [BindProperty]
        public List<Equipment> Equipment { get; set; }
        public Member Member { get; set; }
        #endregion

        #region Constructor
        public ShowToolsModel(IEquipmentRepository equipRepo, Member member)
        {
            _equipmentRepository = equipRepo;
            Member = member;
        }
        #endregion

        #region Methods
        public void OnGet(int id)
        {
            Equipment = _equipmentRepository.GetAll();
        }
        #endregion
    }
}
