using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;

namespace HilleredSailors.Pages.member
{
    public class MemberPAgeModel : PageModel
    {
        public bool edit { get; set; } = true;
        private Member m;
        private Member s;
        private IMemberRepository _mRepository;
        [BindProperty]
        public Member Member { get; set; }
        public MemberPAgeModel(Member member , IMemberRepository IMR) {
            
            _mRepository = IMR;
            foreach (Member m1 in IMR.GetAll())
            {
                if (m1.Name == member.Name) {
                    int t = member.Id;
                    member = m1;
                    member.Id = t;
                }
            }
            m = member;
        }

        public void OnGet() {
            Member = m;
        }

        public void OnPost() { 
            
        }

        public void OnPostWannaEdit() { 
            edit= false;
            Member = m;
            Page();
        }

        public void OnPostFinnishEdit() { 
            edit = true;
            Member.Id = m.Id;
            _mRepository.UpdateMember(Member.Id,Member);
            
            Page();
        }

        
        
       
    }
}
