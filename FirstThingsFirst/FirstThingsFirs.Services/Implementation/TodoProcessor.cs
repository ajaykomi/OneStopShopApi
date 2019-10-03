using FirstThingsFirs.Services.Interfaces;
using FirstThingsFirst.Models.ToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstThingsFirs.Services.Implementation
{
    public class TodoProcessor : ITodoProcessor
    {
        public TodoProcessor()
        {
        }

        public IEnumerable<TodoReminder> GetAllTasks()
        {
            throw new NotImplementedException();
        }
    }
}
