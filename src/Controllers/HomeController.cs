using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace lr10.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index(Consultation consultation)
        {
            if (consultation.Product == "Основи" && consultation.ConsultationDate.DayOfWeek == DayOfWeek.Monday)
            {
                ModelState.AddModelError("Osnovy","Будь ласка, оберіть не понеділок для предмету \\\"Основи\\\"\"");
            }

            if (HttpContext.Request.Method == "POST" && !TryValidateModel(consultation))
            {
                ViewBag.Errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            }

            return View();
        }
    }
}
