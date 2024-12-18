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
        public Member Member { get; set; }

        public RegisterForEventsModel(IMemberRepository IMR, IEventRepository eventRepo, Member m)
        {
            Member = m;
            memberRepo = IMR;
            this.eventRepo = eventRepo;
        }

       

        public void OnPostAddMember(string i) {
            Event temp = eventRepo.GetEvent(DateTime.Parse(i));
            
            temp.AddParticipant(Member);
            
            
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
