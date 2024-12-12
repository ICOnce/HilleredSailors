using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.member
{
    public class ShowMembersModel : PageModel
    {
        private IMemberRepository _memberRepository;

        public List<IMember> Members { get { return _memberRepository.GetAll(); } }

        public ShowMembersModel(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public void OnGet()
        {

        }
    }
}
