using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstThingsFirst.Models.ToDo
{
    public class TodoReminder
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}
