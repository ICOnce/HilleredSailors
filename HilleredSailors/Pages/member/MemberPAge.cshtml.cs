using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.member
{
    public class MemberPAgeModel : PageModel
    {
        [BindProperty]
        public Member Member { get; set; }
        public IActionResult OnGet(Member m)
        {
            Member = m;
            return Page();
        }
    }
}
