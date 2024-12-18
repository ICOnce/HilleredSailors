using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using BoatLibrary.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Tools
{
    public class AddToolsModel : PageModel
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
        public AddToolsModel(IEquipmentRepository equipment, Member member)
        {
            _equipmentRepository = equipment;
            Member = member;
        }
        #endregion

        #region Methods
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _equipmentRepository.AddEquipment(Equipment);
            return RedirectToPage("ShowTools");
        }
        #endregion
    }
}
