using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Equipment
{
    public class BorrowEquipmentModel : PageModel
    {
        public Member Member { get; set; }

        public BorrowEquipmentModel(Member m) { 
            Member = m;
        }
        public void OnGet()
        {
        }
    }
}
