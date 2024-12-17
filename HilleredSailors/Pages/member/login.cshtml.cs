using Microsoft.AspNetCore.Mvc;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.member
{
    public class loginModel : PageModel
    {
        private Member test;
        [BindProperty]
        public Member LogIn { get; set; }
        
        
        IMemberRepository _memberRepo;
        public loginModel(Member logIn , IMemberRepository IMR) { 
            test = logIn;
            _memberRepo = IMR;
        }
        public void OnGet(string i)
        {
        }

        public IActionResult OnPost() {
            
            foreach (Member member in _memberRepo.GetAll()) {
                if (member.Name == LogIn.Name)
                {
                    test.Name = member.Name;
                    test.Email = member.Email;
                    test.Phone = member.Phone;
                    Program.LoggedIn = true;
                    return Redirect("/Index");
                }
            }
            return Page();
        }
    }
}
