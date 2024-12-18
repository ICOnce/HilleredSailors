using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.member
{
    public class DelteMemberModel : PageModel
    {
        IMemberRepository _memberRepository;
        IBookingRepository _bookingRepository;
        IEventRepository _eventRepository;
        public Member Member { get; set; }
        [BindProperty]
        public Member member { get; set; }

        public DelteMemberModel(IMemberRepository IMR, IBookingRepository IBR, IEventRepository IER, Member m) {
            Member = m;
            _memberRepository = IMR;
            _bookingRepository = IBR;
            _eventRepository = IER;
        }
        public void OnGet(int id)
        {
            member=_memberRepository.GetMember(id);
            member.Id = id;
        }

        public IActionResult OnPost() {
            foreach (Event e in _eventRepository.GetAll()) {
                e.RemoveParticipant(member);
            }
            while (_bookingRepository.GetBookingByMember(member)!=null) _bookingRepository.DeleteBooking(_bookingRepository.GetBookingByMember(member).Id);
            _memberRepository.DeleteMember(member.Id);
            return RedirectToPage("/Index");
        }
    }
}
