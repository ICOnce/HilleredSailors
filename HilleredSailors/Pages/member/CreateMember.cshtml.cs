using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;

namespace HilleredSailors.Pages.member
{
    public class CreateMemberModel : PageModel
    {
        public IMemberRepository _memberRepository;

        public CreateMemberModel(IMemberRepository mRepo)
        {
            _memberRepository = mRepo;
        }

        [BindProperty]
        public Member Member { get; set; }
       
        public void OnGet()
        {
        }

        public IActionResult OnPost() { 
            _memberRepository.AddMember(Member);
            return RedirectToPage("/Index");
        }
    }
}
