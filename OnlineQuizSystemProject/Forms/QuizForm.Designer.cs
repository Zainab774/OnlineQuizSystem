namespace OnlineQuizSystemProject.Forms
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            lblTitle = new Label();
            progressBar = new ProgressBar();
            lblQuestion = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(354, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(104, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "\"Quiz\"";
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(30, 41, 59);
            progressBar.ForeColor = Color.FromArgb(99, 102, 241);
            progressBar.Location = new Point(94, 78);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(580, 38);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 1;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(141, 130);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(132, 36);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Question:";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(71, 85, 105);
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(94, 458);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(140, 40);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(99, 102, 241);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(309, 458);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 40);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(16, 185, 129);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(525, 458);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(140, 40);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 530);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnSubmit);
            Controls.Add(lblQuestion);
            Controls.Add(progressBar);
            Controls.Add(lblTitle);
            Name = "QuizForm";
            Text = "QuizForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ProgressBar progressBar;
        private Label lblQuestion;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnSubmit;
    }
}