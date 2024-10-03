using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WaterWise.Models;

namespace WaterWise.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CalculateWaterIntake(WaterIntakeModel model)
        {
            double baseWaterIntake = model.Weight * 0.033;

            if (model.ActivityLevel == "Moderate")
                baseWaterIntake += 0.5;
            else if (model.ActivityLevel == "High")
                baseWaterIntake += 1.0;

            if (model.Climate == "Warm")
                baseWaterIntake += 0.5;
            else if (model.Climate == "Hot")
                baseWaterIntake += 1.0;

            model.RecommendedWaterIntake = Math.Round(baseWaterIntake, 2);
            return Json(model.RecommendedWaterIntake);
        }
        [HttpPost]
        public JsonResult TrackWaterIntake(double waterLogged, double dailyGoal)
        {
            double progress = (waterLogged / dailyGoal) * 100;
            return Json(progress);
        }
        [HttpGet]
        public IActionResult FAQs()
        {
            return View();
        }
    }
}