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

        public TasksSQL(SqlConnection con):base(con)
        {

        }

        public List<TasksModel> SelectAll(int SelectedDayID)
        {
            try
            {
                List<TasksModel> TasksList = new List<TasksModel>();
                SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_SelectAllTasks", new SqlParameter[1]
                    {
                        new SqlParameter("@TaskDaysID",SelectedDayID)
                    });
                    while(dr.Read())
                {
                    TasksModel task = new TasksModel();
                    task.TaskTitle = dr["TaskTitle"].ToString();
                    task.TaskText = dr["TaskText"].ToString();
                    task.TaskID = Convert.ToInt32(dr["TaskID"].ToString());
                    TasksList.Add(task);                   
                }
                return TasksList;              
            }
            catch
            {

                throw;
            }
        }
        public TasksModel SelectSingle(int SelectedTaskID)
        {
            TasksModel task = new TasksModel();
            SqlDataReader dr = ExecuteReader(CommandType.StoredProcedure, @"SP_SelectSingleTask", new SqlParameter[1]
                     {
                        new SqlParameter("@TaskID",SelectedTaskID)
                     });
            while (dr.Read())
            {
               
                task.TaskTitle = dr["TaskTitle"].ToString();
                task.TaskText = dr["TaskText"].ToString();
                task.TaskID = Convert.ToInt32(dr["TaskID"].ToString());
               
            }
            return task;
        }
       
        public void Insert(TasksModel obj)
        {
            try
            {
                ExecuteScalar(CommandType.StoredProcedure, @"SP_InsertTask",
                    new SqlParameter[3]
                    {
                         new SqlParameter("@TaskTitle",obj.TaskTitle),
                         new SqlParameter("@TaskText",obj.TaskText),
                         new SqlParameter("@TaskDayID", obj.TaskDaysID)
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
                ExecuteScalar(CommandType.StoredProcedure, @"SP_UpdateTask",
                    new SqlParameter[3]
                    {
                         new SqlParameter("@TaskTitle",obj.TaskTitle),
                         new SqlParameter("@TaskID",obj.TaskID),
                         new SqlParameter("@TaskText",obj.TaskText),                      
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
                ExecuteScalar(CommandType.StoredProcedure, @"SP_DeleteTask",
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