using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    public class RemoveTaskEventArgs : EventArgs
    {
        public Task Task { get; set; }
        public RemoveTaskEventArgs(Task task)
        {
            this.Task = task;
        }
    }
}
