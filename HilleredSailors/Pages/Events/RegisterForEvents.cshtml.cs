using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HilleredSailors.Pages.Events
{
    public class RegisterForEventsModel : PageModel
    {
        public IMemberRepository memberRepo;
        public IEventRepository eventRepo;
        private List<IMember> members=new List<IMember>();
        [BindProperty]
        public List<SelectListItem> memberList { get; set; }
        [BindProperty]
        public int MemberID { get; set; }

        public RegisterForEventsModel(IMemberRepository IMR, IEventRepository eventRepo)
        {
            memberRepo = IMR;
            memberList = new List<SelectListItem>();
            FillList();
            this.eventRepo = eventRepo;
        }

        void FillList() {
            memberList.Clear();
            foreach (IMember m in memberRepo.GetAll())
            {
                SelectListItem item = new SelectListItem(m.Name, m.Id.ToString());
                memberList.Add(item);
            }
        }

        public void OnPostAddMember(string i) {
            Event temp = (Event)eventRepo.GetEvent(DateTime.Parse(i));
            
            temp.AddParticipant(memberRepo.GetMember(MemberID));
            FillList();
            
        }

        public IActionResult OnPostFinnish(string i) {
            Console.WriteLine("no");
            Event temp = (Event)eventRepo.GetEvent(DateTime.Parse(i));
            foreach (IMember m in members) { 
                temp.AddParticipant(m);
            }
            return Redirect("ShowEvents");
        }
    }
}
