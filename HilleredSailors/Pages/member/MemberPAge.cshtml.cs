using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;

namespace HilleredSailors.Pages.member
{
    public class MemberPAgeModel : PageModel
    {
        public IMemberRepository mRepo;
        public MemberPAgeModel(IMemberRepository mr) {
            mRepo = mr;
        }

        [BindProperty]
        public Member Member { get; set; }
        public IActionResult OnGet(int t)
        {
            Member=mRepo.GetMember(1);

            return Page();
        }
    }
}
