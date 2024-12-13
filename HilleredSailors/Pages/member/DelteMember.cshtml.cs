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
        [BindProperty]
        public Member Member { get; set; }

        public DelteMemberModel(IMemberRepository IMR, IBookingRepository IBR, IEventRepository IER) {
            _memberRepository = IMR;
            _bookingRepository = IBR;
            _eventRepository = IER;
        }
        public void OnGet(int id)
        {
            Member=_memberRepository.GetMember(id);
            Member.Id = id;
        }

        public IActionResult OnPost() {
            foreach (Event e in _eventRepository.GetAll()) {
                e.RemoveParticipant(Member);
            }
            while (_bookingRepository.GetBookingByMember(Member)!=null) _bookingRepository.DeleteBooking(_bookingRepository.GetBookingByMember(Member).Id);
            _memberRepository.DeleteMember(Member.Id);
            return RedirectToPage("/Index");
        }
    }
}
