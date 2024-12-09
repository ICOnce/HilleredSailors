using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;

namespace HilleredSailors.Pages.Boats
{
    public class ShowBoatsModel : PageModel
    {
        public IBoatRepository BRepo;

        public ShowBoatsModel(IBoatRepository br) { 
            BRepo = br;
        }
        public void OnGet()
        {
        }
    }
}
