namespace OnlineQuizSystemProject.Forms
{
    partial class StudentDashboard
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
            btnLogout = new Button();
            btnViewResult = new Button();
            btnStartQuiz = new Button();
            lblTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnViewResult);
            panel1.Controls.Add(btnStartQuiz);
            panel1.Location = new Point(240, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 253);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(239, 68, 68);
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.WhiteSmoke;
            btnLogout.Location = new Point(78, 167);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(138, 41);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "🚪Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewResult
            // 
            btnViewResult.BackColor = Color.FromArgb(99, 102, 241);
            btnViewResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewResult.ForeColor = Color.WhiteSmoke;
            btnViewResult.Location = new Point(78, 97);
            btnViewResult.Name = "btnViewResult";
            btnViewResult.Size = new Size(148, 41);
            btnViewResult.TabIndex = 1;
            btnViewResult.Text = "📊View Result";
            btnViewResult.UseVisualStyleBackColor = false;
            btnViewResult.Click += btnViewResult_Click;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.BackColor = Color.FromArgb(16, 185, 129);
            btnStartQuiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQuiz.ForeColor = Color.WhiteSmoke;
            btnStartQuiz.Location = new Point(78, 32);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(138, 46);
            btnStartQuiz.TabIndex = 0;
            btnStartQuiz.Text = "▶Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = false;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(232, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Welcome Student!";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = OnlineQuizSystemProject.Properties.Resources.download__7_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "StudentDashboard";
            Text = "StudentDashboaed";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnViewResult;
        private Button btnStartQuiz;
        private Label lblTitle;
    }
}