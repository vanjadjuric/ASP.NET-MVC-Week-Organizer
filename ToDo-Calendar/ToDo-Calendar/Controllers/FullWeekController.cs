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
            List<TasksModel> Tasks = new List<TasksModel>();
            for (int i = 0; i < 12; i++)
            {
                TasksModel model = new TasksModel();
                model.TaskDaysID = 1;
                model.TaskText = " Today we need to do something about this site blah blah i am watching a stream and just testing this thing";
                Tasks.Add(model);
            }
            day.TaskDaysID = id;
            
            return View(Tasks);
        }
        public ActionResult SelectedTask()
        {
            return View();
        }
    }
}