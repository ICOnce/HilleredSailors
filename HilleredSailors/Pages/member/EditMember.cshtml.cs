using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.member
{
    public class EditMemberModel : PageModel
    {
        IMemberRepository _memberRepository;
        IBookingRepository _bookingRepository;
        IEventRepository _eventRepository;
        [BindProperty]
        public Member member { get; set; }

        public Member Member { get; set; }

        public EditMemberModel(IMemberRepository IMR, Member m)
        {
            Member = m;
            _memberRepository = IMR;
        }
        public void OnGet(int id)
        {
            member = _memberRepository.GetMember(id);
        }

        public IActionResult OnPost()
        {
            _memberRepository.UpdateMember(member.Id, member);
            return RedirectToPage("/Index");
        }
    }
}
