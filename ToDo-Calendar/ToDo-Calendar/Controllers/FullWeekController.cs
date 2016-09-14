using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo_Calendar.Models;
using ToDo_Calendar.Business.Interfaces;
using ToDo_Calendar.Business.Classes;

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
          
            TasksBusiness SelectTasks = new TasksBusiness();
            List<TasksModel> TaskList;
            TaskList = SelectTasks.SelectAll(id);
            TempData["SelectedDayID"] = id;

            return View(TaskList);
        }
        public ActionResult SelectedTask()
        {
            return View();

        }
        public ActionResult InsertNewTask(TasksModel obj)
        {
            int selectedDayID = Convert.ToInt32(TempData["SelectedDayID"]);
            TasksBusiness insertTask = new TasksBusiness();          
            obj.TaskDaysID = selectedDayID;        
            insertTask.Insert(obj);
            
            return RedirectToAction("SelectedDay",new { id = selectedDayID });
            
        }
        public ActionResult BackToSelectedDay()
        {
            int selectedDayID = Convert.ToInt32(TempData["SelectedDayID"]);
                      
            return RedirectToAction("SelectedDay", new { id = selectedDayID });

        }
        public ActionResult DeleteTask(int id)
        {
            TasksBusiness tb = new TasksBusiness();
            tb.Delete(id);
            int selectedDayID = Convert.ToInt32(TempData["SelectedDayID"]);


            return RedirectToAction("SelectedDay", new { id = selectedDayID });
        }
        public ActionResult EditSelectedTask(int id)
        {
            TasksBusiness task = new TasksBusiness();
            TempData["SelectedTaskID"] = id;

            return View(task.SelectSingle(id));
        }
        public ActionResult InsertEditedTask(TasksModel obj)
        {
            TasksBusiness task = new TasksBusiness();
            int selectedDayID = Convert.ToInt32(TempData["SelectedDayID"]);       
            obj.TaskID = Convert.ToInt32(TempData["SelectedTaskID"]);
            task.Update(obj);
           

            return RedirectToAction("SelectedDay", new { id = selectedDayID });
        }
    }
}