using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo_Calendar.Models
{
    public class TasksModel
    {
        public int TaskID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskText { get; set; }
        public int TaskDaysID { get; set; }

    }
}