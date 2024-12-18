using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;

namespace HilleredSailors.Pages.member
{
    public class CreateMemberModel : PageModel
    {
        public IMemberRepository _memberRepository;
        public Member Member { get; set; }

        public CreateMemberModel(IMemberRepository mRepo, Member m)
        {
            Member = m;
            _memberRepository = mRepo;
        }

        [BindProperty]
        public Member member { get; set; }
       
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            try
            {
                _memberRepository.AddMember(member);
                return RedirectToPage("/Index");
            }
            catch (UnavailableEmailException ex)
            {
                ModelState.AddModelError("member.Email", ex.Message);
            }
            return Page();
        }
    }
}
