namespace TODO
{
    partial class Task
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.priorirypnl = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Title = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // priorirypnl
            // 
            this.priorirypnl.BackColor = System.Drawing.Color.Transparent;
            this.priorirypnl.BorderRadius = 5;
            this.priorirypnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.priorirypnl.FillColor = System.Drawing.Color.IndianRed;
            this.priorirypnl.FillColor3 = System.Drawing.Color.Crimson;
            this.priorirypnl.FillColor4 = System.Drawing.Color.SeaShell;
            this.priorirypnl.Location = new System.Drawing.Point(0, 0);
            this.priorirypnl.Name = "priorirypnl";
            this.priorirypnl.ShadowDecoration.Parent = this.priorirypnl;
            this.priorirypnl.Size = new System.Drawing.Size(25, 71);
            this.priorirypnl.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(121, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(75, 27);
            this.Title.TabIndex = 1;
            this.Title.Text = "label1";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Description.Location = new System.Drawing.Point(122, 39);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 23);
            this.Description.TabIndex = 2;
            this.Description.Text = "label2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox1.Location = new System.Drawing.Point(25, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(32, 71);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::TODO.Properties.Resources.trash;
            this.pictureBox1.Location = new System.Drawing.Point(57, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.priorirypnl);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(837, 71);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel priorirypnl;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
