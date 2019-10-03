using FirstThingsFirst.Models.ToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstThingsFirs.Services.Interfaces
{
   public interface ITodoProcessor
    {
        IEnumerable<TodoReminder> GetAllTasks();
    }
}
