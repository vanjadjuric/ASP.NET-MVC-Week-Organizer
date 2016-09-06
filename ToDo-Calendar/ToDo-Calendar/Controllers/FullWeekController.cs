using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo_Calendar.Models;

namespace ToDo_Calendar.Controllers
{
    public class FullWeekController : Controller
    {
        // GET: FullWeek
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SelectedDay(int id)
        {
            DayModel day = new DayModel();
            day.id = id;
            return View(day);
        }
    }
}