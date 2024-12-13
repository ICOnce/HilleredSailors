using BoatLibrary.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleredSailors.Pages.Boats
{
    public class AddToLogModel : PageModel
    {
        private BoatRepo bRepo;

        [BindProperty]
        public Log log { get; private set; }

        public List <String> LogMessages { get; private set; }

        [BindProperty]
        public String NewLogLine {  get; set; }

        [BindProperty]
        public String SailNumber { get; set; }

        public AddToLogModel(IBoatRepository boatRepository) 
        {
            bRepo = (BoatRepo)boatRepository;
        }
        public void OnGet(string showSN)
        {
            SailNumber = showSN;
            log = (Log) bRepo.GetBoat(SailNumber).Log;
            LogMessages = log.GetAll();
        }

        public IActionResult OnPost()
        {
            log = (Log)bRepo.GetBoat(SailNumber).Log;
            log.AddEntry(NewLogLine);
            LogMessages = log.GetAll();
            return Page();
        }
    }
}
