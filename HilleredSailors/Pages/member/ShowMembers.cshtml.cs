using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.member
{
    public class ShowMembersModel : PageModel
    {
        private IMemberRepository _memberRepository;

        public List<Member> Members { get { return _memberRepository.GetAll(); } }
        public Member Member { get; set; }

        public ShowMembersModel(IMemberRepository memberRepository, Member m)
        {
            Member = m;
            _memberRepository = memberRepository;
        }

        public void OnGet()
        {

        }
    }
}
