using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.member
{
    public class CreateMemberModel : PageModel
    {
        public IMemberRepository MemberRepository;
        [BindProperty]
        public Member m { get; set; }
        public CreateMemberModel(IMemberRepository mRepo) { 
        MemberRepository = mRepo;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost() { 
            MemberRepository.AddMember(m);
            Console.WriteLine(MemberRepository.MemberCount);
            return RedirectToPage("MemberPAge");
        }
    }
}
