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
        public Member Member { get; set; }

        public EditMemberModel(IMemberRepository IMR)
        {
            _memberRepository = IMR;
        }
        public void OnGet(int id)
        {
            Member = _memberRepository.GetMember(id);
        }

        public IActionResult OnPost()
        {
            _memberRepository.UpdateMember(Member.Id, Member);
            return RedirectToPage("/Index");
        }
    }
}
