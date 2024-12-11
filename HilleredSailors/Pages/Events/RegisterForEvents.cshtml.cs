using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HilleredSailors.Pages.Events
{
    public class RegisterForEventsModel : PageModel
    {
        IMemberRepository memberRepo;
        IEventRepository eventRepo;
        private List<IMember> members=new List<IMember>();
        public List<SelectListItem> memberList { get; set; }
        public int MemberID { get; set; }
        [BindProperty]
        public Event Event { get; set; }

        public RegisterForEventsModel(IMemberRepository IMR, IEventRepository eventRepo )
        {
            memberRepo = IMR;
            memberList = new List<SelectListItem>();
            FillList();
            this.eventRepo = eventRepo;
        }

        void FillList() {
            foreach (IMember m in memberRepo.GetAll())
            {
                SelectListItem item = new SelectListItem(m.Name, m.Id.ToString());
                memberList.Add(item);
            }
        }

        public void OnPostAddMember() {
            members.Add(memberRepo.GetMember(MemberID));
            Page();
        }

        public IActionResult OnPostFinnish() {
            foreach (IMember m in members) { 
                Event.AddParticipant(m);
            }
            return Redirect("ShowEvents");
        }
    }
}
