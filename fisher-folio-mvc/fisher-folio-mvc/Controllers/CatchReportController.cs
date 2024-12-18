using fisher_folio_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace fisher_folio_mvc.Controllers
{
    public class CatchReportController : Controller
    {
        public IActionResult Index()
        {
            // TEST  Test for object  TEST
            Catch fishCatch = new Catch
            {
                CatchId = 1,
                UserId = 1, // Antag, at dette er ID for en eksisterende bruger
                FishSpecies = "Trout",
                Location = "Lake X",
                CatchDate = DateTime.Now
            };
            //TEST  Test for object  TEST
            return View(fishCatch);
        }
    }
}
