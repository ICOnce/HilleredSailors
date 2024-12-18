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
        private IMemberRepository _mRepository;
        [BindProperty]
        public Member Member { get; set; }
        public MemberPAgeModel(Member member , IMemberRepository IMR) {
            
            _mRepository = IMR;
            foreach (Member m1 in _mRepository.GetAll())
            {
                if (m1.Name == member.Name) {
                    int t = member.Id;
                    member = m1;
                    member.Id = t;
                }
            }
            m = member;
            Member = member;
        }

        public void OnGet() {
            
        }

        public void OnPost() { 
            
        }

        public void OnPostWannaEdit() { 
            edit= false;
            //Member = m;
        }

        public IActionResult OnPostFinnishEdit() { 
            edit = true;
            Member.Id = m.Id;
            Member.Type = m.Type;
            
            _mRepository.UpdateMember(Member.Id,Member);

            m.Name = Member.Name;
            m.Phone = Member.Phone;
            m.Email = Member.Email;
            m.Type = Member.Type;
            m.Id = Member.Id;
            return Page();
        }

        
        
       
    }
}
