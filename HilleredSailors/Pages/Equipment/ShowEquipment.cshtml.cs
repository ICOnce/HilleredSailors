using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Equipment
{
    public class ShowEquipmentModel : PageModel
    {
        public Member Member { get; set; }

        public ShowEquipmentModel(Member m) { 
            Member = m;
        }
        public void OnGet()
        {
        }
    }
}
