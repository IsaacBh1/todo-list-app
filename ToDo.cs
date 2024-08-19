using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TODO
{


    public partial class Todo : Form
    {
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );


        public Todo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                //MessageBox.Show("What the Ctrl+F?");
                this.Close(); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddTaskForm task = new AddTaskForm();
            task.TaskAdded += AddNewTask; 
            task.ShowDialog();
        }

        private void AddNewTask(object sender, AddNewTaskEventArgs e)
        {
            Task newTask = new Task(e.Title, e.Desc, e.priority);
            newTask.RemoveTask += RemoveTask; 
            flowLayoutPanel1.Controls.Add(newTask);

        }

        private void RemoveTask(object sender, RemoveTaskEventArgs e)
        {
            flowLayoutPanel1.Controls.Remove(e.Task);
        }
    }
}
