using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Objects;
namespace HilleredSailors.Pages
{
    public class IndexModel : PageModel
    {
        public IMemberRepository MemberRepository { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
