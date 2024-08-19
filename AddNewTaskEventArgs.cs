using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{

    public class AddNewTaskEventArgs : EventArgs
    {
        public AddNewTaskEventArgs(string title, string desc, int priority)
        {
            Title = title;
            Desc = desc;
            this.priority = priority;
        }

        public string Title { get; set; }
        public string Desc { get; set; }
        public int priority { get; set; }


    }

}
