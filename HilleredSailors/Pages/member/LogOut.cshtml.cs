using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.member
{
    public class LogOutModel : PageModel
    {
        public Member Member { get; set; }
        private Member m;
        public LogOutModel(Member m) {
            m.Name="";
            m.Email = "";
            m.Phone = string.Empty;
            m.Type=MemberType.MemberTypes.member;
            Member = m;
            
        }

        
    }
}
