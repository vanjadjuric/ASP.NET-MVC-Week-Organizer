using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Calendar.Models;

namespace ToDo_Calendar.DataAccess.Interfaces
{
    public interface ITasks
    {
        void SelectAll();
        void Insert(TasksModel obj);
        void Update(TasksModel obj);
        void Delete(int id);


    }
}
