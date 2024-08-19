using System;
using System.Drawing;
using System.Windows.Forms;

namespace TODO
{
    public partial class Task : UserControl
    {
        public event EventHandler<RemoveTaskEventArgs> RemoveTask;

        public int priority = -1; 
        public Task(string title , string desc , int priority)
        {
            InitializeComponent();
            Title.Text = title;
            Description.Text = desc;
            switch (priority)
            {
                case 0:  
                    priorirypnl.FillColor = Color.Green;
                    priorirypnl.FillColor2 = Color.Green;
                    priorirypnl.FillColor3 = Color.Green;
                    priorirypnl.FillColor4 = Color.Green;
                    break;
                case 1:
                    priorirypnl.FillColor = Color.Yellow;
                    priorirypnl.FillColor2 = Color.Yellow;
                    priorirypnl.FillColor3 = Color.Yellow;
                    priorirypnl.FillColor4 = Color.Yellow;
                    break;

                case 2:
                    priorirypnl.FillColor = Color.Red;
                    priorirypnl.FillColor2 = Color.Red;
                    priorirypnl.FillColor3 = Color.Red;
                    priorirypnl.FillColor4 = Color.Red;
                    break;

            }
        }
        public Task()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            RemoveTask?.Invoke(this, new RemoveTaskEventArgs(this)); 
        }
    }
}
