using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Equipment
{
    public class AddEquipmentModel : PageModel
    {
        public Member Member { get; set; }

        public AddEquipmentModel(Member m) {
            Member = m;
        }
        public void OnGet()
        {
        }
    }
}
