using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;




namespace TODO
{



    public partial class AddTaskForm : Form
    {

        public event EventHandler<AddNewTaskEventArgs> TaskAdded; 

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



        public AddTaskForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Close(); 
        }
     

        private int GetPriority()
        {
            switch(guna2ComboBox1.Text)
            {
                case "Low":
                    return 0;
                case "Medium":
                    return 1;
                case "High":
                    return 2;
            }
            return 0; 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TaskAdded?.Invoke(this, new AddNewTaskEventArgs(guna2TextBox1.Text, guna2TextBox2.Text, GetPriority()));
        }
    }
}
