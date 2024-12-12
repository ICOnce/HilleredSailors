using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class AddToLogModel : PageModel
    {
        private BoatRepo bRepo;

        public List<string> LogMessages { get; set; }

        public AddToLogModel(IBoatRepository boatRepository) 
        {
            bRepo = (BoatRepo) boatRepository;
        }
        public void OnGet(string showSN)
        {
            Log log = (Log) bRepo.GetBoat(showSN).Log;
            LogMessages = log.GetAll();
        }
    }
}
