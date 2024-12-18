using Microsoft.AspNetCore.Mvc;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BoatLibrary.Repos;

namespace HilleredSailors.Pages.Events
{
    public class ShowEventsModel : PageModel
    {
        public IEventRepository EventRepository { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        [BindProperty]
        public int MemberID { get; set; }
        [BindProperty]
        public List<SelectListItem> memberList { get; set; }
        [BindProperty]
        public List<Member> Members { get; set; }
        public Member Member { get; set; }
        public ShowEventsModel(IEventRepository IER, IMemberRepository IMR, Member m) {
            Member = m;
            EventRepository = IER;
            MemberRepository = IMR;

            memberList = new List<SelectListItem>();
            FillList();
        }

        void FillList()
        {
            memberList.Clear();
            foreach (Member m in MemberRepository.GetAll())
            {

                SelectListItem item = new SelectListItem(m.Name, m.Id.ToString());
                memberList.Add(item);
            }
        }
        public void OnGet(){
            Members = new List<Member>();
        }

        public void OnPostAddMember(string i)
        {
            Event temp = EventRepository.GetEvent(DateTime.Parse(i));
            if (temp._participants.Count < temp.MaxParticipants) {
                temp.AddParticipant(MemberRepository.GetMember(MemberID));
            }
            FillList();
        }
    }
}
