using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace HilleredSailors.Pages.Shared
{
    public class _LayoutModel
    {
        public Member Member { get; set; }
        public _LayoutModel(Member m) { 
            Member = m;
        }
    }
}
