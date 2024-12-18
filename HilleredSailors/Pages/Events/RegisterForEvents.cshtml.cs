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
        private List<Member> members=new List<Member>();
        [BindProperty]
        public List<SelectListItem> memberList { get; set; }
        [BindProperty]
        public int MemberID { get; set; }

        public Member Member { get; set; }

        public RegisterForEventsModel(IMemberRepository IMR, IEventRepository eventRepo, Member m)
        {
            Member = m;
            memberRepo = IMR;
            memberList = new List<SelectListItem>();
            FillList();
            this.eventRepo = eventRepo;
        }

        void FillList() {
            memberList.Clear();
            foreach (Member m in memberRepo.GetAll())
            {
                SelectListItem item = new SelectListItem(m.Name, m.Id.ToString());
                memberList.Add(item);
            }
        }

        public void OnPostAddMember(string i) {
            Event temp = eventRepo.GetEvent(DateTime.Parse(i));
            
            temp.AddParticipant(memberRepo.GetMember(MemberID));
            FillList();
            
        }

        public IActionResult OnPostFinnish(string i) {
            Console.WriteLine("no");
            Event temp = eventRepo.GetEvent(DateTime.Parse(i));
            foreach (Member m in members) { 
                temp.AddParticipant(m);
            }
            return Redirect("ShowEvents");
        }
    }
}
