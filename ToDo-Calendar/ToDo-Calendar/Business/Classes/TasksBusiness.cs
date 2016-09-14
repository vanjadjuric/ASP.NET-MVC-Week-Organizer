using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Calendar.Business.Interfaces;
using ToDo_Calendar.DataAccess.Classes;
using ToDo_Calendar.Models;
using ToDo_Calendar.Business.Classes;
using ToDo_Calendar.Connection;

namespace ToDo_Calendar.Business.Classes
{
    class TasksBusiness :ConnectionMenager, ITasksBusiness
    {
        TasksSQL TasksDataLayer;     

        public TasksBusiness()
        {
            TasksDataLayer = new TasksSQL(Conn);
        }

        public List<TasksModel> SelectAll(int SelectedDayID)
        {
            try
            {
                Open();
                return TasksDataLayer.SelectAll(SelectedDayID);
            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }
        }
        public TasksModel SelectSingle(int SelectedTaskID)
        {
            try
            {
                Open();
                return TasksDataLayer.SelectSingle(SelectedTaskID);

            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public void Insert(TasksModel obj)
        {
            try
            {
                Open();
                TasksDataLayer.Insert(obj);
            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public void Update(TasksModel obj)
        {
            try
            {
                Open();
                TasksDataLayer.Update(obj);

            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }
        }

        public void Delete(int id)
        {
            try
            {
                Open();
                TasksDataLayer.Delete(id);
            }
            catch 
            {

                throw;
            }
            finally
            {
                Close();
            }
        }
    }
}
