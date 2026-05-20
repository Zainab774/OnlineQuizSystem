namespace OnlineQuizSystemProject.Forms
{
    partial class TeacherDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnViewResult = new Button();
            btnLogOut = new Button();
            btnCreateQuiz = new Button();
            lblTitle = new Label();
            btnManageQuizzes = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnManageQuizzes);
            panel1.Controls.Add(btnViewResult);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnCreateQuiz);
            panel1.Location = new Point(226, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 252);
            panel1.TabIndex = 0;
            // 
            // btnViewResult
            // 
            btnViewResult.BackColor = Color.FromArgb(99, 102, 241);
            btnViewResult.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewResult.ForeColor = Color.White;
            btnViewResult.Location = new Point(67, 82);
            btnViewResult.Name = "btnViewResult";
            btnViewResult.Size = new Size(159, 41);
            btnViewResult.TabIndex = 1;
            btnViewResult.Text = "📊View Result";
            btnViewResult.UseVisualStyleBackColor = false;
            btnViewResult.Click += btnViewResult_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(239, 68, 68);
            btnLogOut.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(79, 190);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(135, 39);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "🚪Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnCreateQuiz
            // 
            btnCreateQuiz.BackColor = Color.FromArgb(251, 146, 60);
            btnCreateQuiz.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateQuiz.ForeColor = Color.White;
            btnCreateQuiz.Location = new Point(56, 20);
            btnCreateQuiz.Name = "btnCreateQuiz";
            btnCreateQuiz.Size = new Size(170, 43);
            btnCreateQuiz.TabIndex = 0;
            btnCreateQuiz.Text = "✏Create Quiz";
            btnCreateQuiz.UseVisualStyleBackColor = false;
            btnCreateQuiz.Click += btnCreateQuiz_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(215, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Welcome Teacher!";
            // 
            // btnManageQuizzes
            // 
            btnManageQuizzes.BackColor = Color.FromArgb(128, 128, 255);
            btnManageQuizzes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageQuizzes.ForeColor = Color.White;
            btnManageQuizzes.Location = new Point(65, 140);
            btnManageQuizzes.Name = "btnManageQuizzes";
            btnManageQuizzes.Size = new Size(161, 34);
            btnManageQuizzes.TabIndex = 2;
            btnManageQuizzes.Text = "Manage Quizzes";
            btnManageQuizzes.UseVisualStyleBackColor = false;
            btnManageQuizzes.Click += btnManageQuizzes_Click;
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__8_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "TeacherDashboard";
            Text = "TeacherDashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnViewResult;
        private Button btnLogOut;
        private Button btnCreateQuiz;
        private Label lblTitle;
        private Button btnManageQuizzes;
    }
}