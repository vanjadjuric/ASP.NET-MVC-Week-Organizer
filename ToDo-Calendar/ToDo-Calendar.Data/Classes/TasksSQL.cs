using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ToDo_Calendar.Data.Classes;
using ToDo_Calendar.DataAccess.Interfaces;
using ToDo_Calendar.Models;


namespace ToDo_Calendar.DataAccess.Classes
{
    public class TasksSQL :SqlExecuteMethods, ITasks
    {
        public void SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(TasksModel obj)
        {
            try
            {
                ExecuteScalar(CommandType.Text, "Insert into Task values(@TaskTitle,@TaskText,@TaskDayID",
                    new SqlParameter[3]
                    {
                         new SqlParameter("@TaskTitle",obj.TaskTitle),
                         new SqlParameter("@TaskText",obj.TaskText),
                         new SqlParameter("@TaskDaysID", obj.TaskDaysID)
                    });

            }
            catch 
            {

                throw;
            }
        }

        public void Update(TasksModel obj)
        {
            try
            {
                ExecuteScalar(CommandType.Text, "Update Task set TaskTitle=@TaskTitle,TaskText=@TaskText,TaskDaysID=@TaskDayID where TaskID=@TaskID",
                    new SqlParameter[4]
                    {
                         new SqlParameter("@TaskTitle",obj.TaskTitle),
                         new SqlParameter("@TaskID",obj.TaskID),
                         new SqlParameter("@TaskText",obj.TaskText),
                         new SqlParameter("@TaskDaysID", obj.TaskDaysID)
                    });

            }
            catch
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                ExecuteScalar(CommandType.Text, "Delete from Task where TaskID=@TaskID",
                    new SqlParameter[1]
                    {
                        new SqlParameter("@TaskID",id)
                    });

            }
            catch
            {

                throw;
            }
        }

    }
}