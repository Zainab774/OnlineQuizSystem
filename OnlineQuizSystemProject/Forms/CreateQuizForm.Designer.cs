namespace OnlineQuizSystemProject.Forms
{
    partial class CreateQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuizForm));
            lblTitle = new Label();
            lblQuizTitle = new Label();
            txtQuizTitle = new TextBox();
            grpList = new GroupBox();
            lblQCount = new Label();
            lstQuestions = new ListBox();
            lblQText = new Label();
            txtQuestion = new TextBox();
            panel1 = new Panel();
            grpQuestion = new GroupBox();
            btnSaveQuiz = new Button();
            btnAddQuestion = new Button();
            cmbCorrect = new ComboBox();
            lblCorrect = new Label();
            lblOpt1 = new Label();
            lblOpt2 = new Label();
            txtOpt3 = new TextBox();
            txtOpt4 = new TextBox();
            txtOpt1 = new TextBox();
            lblOpt4 = new Label();
            lblOpt3 = new Label();
            txtOpt2 = new TextBox();
            grpList.SuspendLayout();
            panel1.SuspendLayout();
            grpQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(22, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(173, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CreateQuiz";
            // 
            // lblQuizTitle
            // 
            lblQuizTitle.AutoSize = true;
            lblQuizTitle.BackColor = Color.Transparent;
            lblQuizTitle.BorderStyle = BorderStyle.FixedSingle;
            lblQuizTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuizTitle.ForeColor = Color.Black;
            lblQuizTitle.Location = new Point(25, 23);
            lblQuizTitle.Name = "lblQuizTitle";
            lblQuizTitle.Size = new Size(120, 32);
            lblQuizTitle.TabIndex = 1;
            lblQuizTitle.Text = "Quiz Title:";
            // 
            // txtQuizTitle
            // 
            txtQuizTitle.Location = new Point(142, 23);
            txtQuizTitle.Name = "txtQuizTitle";
            txtQuizTitle.Size = new Size(160, 31);
            txtQuizTitle.TabIndex = 2;
            // 
            // grpList
            // 
            grpList.BackColor = Color.Transparent;
            grpList.Controls.Add(lblQCount);
            grpList.Controls.Add(lstQuestions);
            grpList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpList.ForeColor = Color.Black;
            grpList.Location = new Point(25, 455);
            grpList.Name = "grpList";
            grpList.Size = new Size(798, 150);
            grpList.TabIndex = 3;
            grpList.TabStop = false;
            grpList.Text = "\"Questions in this Quiz\"";
            // 
            // lblQCount
            // 
            lblQCount.AutoSize = true;
            lblQCount.BackColor = Color.Transparent;
            lblQCount.ForeColor = Color.Black;
            lblQCount.Location = new Point(560, 70);
            lblQCount.Name = "lblQCount";
            lblQCount.Size = new Size(193, 25);
            lblQCount.TabIndex = 18;
            lblQCount.Text = "\"Questions added: 0\"";
            // 
            // lstQuestions
            // 
            lstQuestions.BorderStyle = BorderStyle.FixedSingle;
            lstQuestions.Font = new Font("Segoe UI", 9.5F);
            lstQuestions.ForeColor = Color.Black;
            lstQuestions.FormattingEnabled = true;
            lstQuestions.Location = new Point(14, 24);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(540, 102);
            lstQuestions.TabIndex = 19;
            // 
            // lblQText
            // 
            lblQText.AutoSize = true;
            lblQText.Location = new Point(14, 24);
            lblQText.Name = "lblQText";
            lblQText.Size = new Size(94, 25);
            lblQText.TabIndex = 4;
            lblQText.Text = "Question:";
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(53, 62);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(625, 31);
            txtQuestion.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(grpQuestion);
            panel1.Controls.Add(txtQuizTitle);
            panel1.Controls.Add(grpList);
            panel1.Controls.Add(lblQuizTitle);
            panel1.Location = new Point(22, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 675);
            panel1.TabIndex = 4;
            // 
            // grpQuestion
            // 
            grpQuestion.BackColor = Color.Transparent;
            grpQuestion.Controls.Add(lblQText);
            grpQuestion.Controls.Add(txtQuestion);
            grpQuestion.Controls.Add(btnSaveQuiz);
            grpQuestion.Controls.Add(btnAddQuestion);
            grpQuestion.Controls.Add(cmbCorrect);
            grpQuestion.Controls.Add(lblCorrect);
            grpQuestion.Controls.Add(lblOpt1);
            grpQuestion.Controls.Add(lblOpt2);
            grpQuestion.Controls.Add(txtOpt3);
            grpQuestion.Controls.Add(txtOpt4);
            grpQuestion.Controls.Add(txtOpt1);
            grpQuestion.Controls.Add(lblOpt4);
            grpQuestion.Controls.Add(lblOpt3);
            grpQuestion.Controls.Add(txtOpt2);
            grpQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpQuestion.ForeColor = Color.Black;
            grpQuestion.Location = new Point(25, 70);
            grpQuestion.Name = "grpQuestion";
            grpQuestion.Size = new Size(798, 379);
            grpQuestion.TabIndex = 18;
            grpQuestion.TabStop = false;
            grpQuestion.Text = "Add a Question";
            // 
            // btnSaveQuiz
            // 
            btnSaveQuiz.BackColor = Color.FromArgb(99, 102, 241);
            btnSaveQuiz.Cursor = Cursors.Hand;
            btnSaveQuiz.FlatStyle = FlatStyle.Flat;
            btnSaveQuiz.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveQuiz.ForeColor = Color.White;
            btnSaveQuiz.Location = new Point(560, 310);
            btnSaveQuiz.Name = "btnSaveQuiz";
            btnSaveQuiz.Size = new Size(200, 44);
            btnSaveQuiz.TabIndex = 17;
            btnSaveQuiz.Text = "💾Save Quiz";
            btnSaveQuiz.UseVisualStyleBackColor = false;
            btnSaveQuiz.Click += btnSaveQuiz_Click;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.FromArgb(16, 185, 129);
            btnAddQuestion.FlatStyle = FlatStyle.Flat;
            btnAddQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.Location = new Point(333, 313);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(200, 38);
            btnAddQuestion.TabIndex = 16;
            btnAddQuestion.Text = "Add Question";
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // cmbCorrect
            // 
            cmbCorrect.BackColor = Color.FromArgb(30, 41, 59);
            cmbCorrect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCorrect.Font = new Font("Segoe UI", 10F);
            cmbCorrect.ForeColor = Color.White;
            cmbCorrect.FormattingEnabled = true;
            cmbCorrect.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cmbCorrect.Location = new Point(168, 271);
            cmbCorrect.Name = "cmbCorrect";
            cmbCorrect.Size = new Size(160, 36);
            cmbCorrect.TabIndex = 14;
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.ForeColor = Color.Black;
            lblCorrect.Location = new Point(14, 277);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(148, 25);
            lblCorrect.TabIndex = 15;
            lblCorrect.Text = "Correct Answer:";
            // 
            // lblOpt1
            // 
            lblOpt1.AutoSize = true;
            lblOpt1.Location = new Point(16, 135);
            lblOpt1.Name = "lblOpt1";
            lblOpt1.Size = new Size(25, 25);
            lblOpt1.TabIndex = 6;
            lblOpt1.Text = "A";
            // 
            // lblOpt2
            // 
            lblOpt2.AutoSize = true;
            lblOpt2.Location = new Point(367, 132);
            lblOpt2.Name = "lblOpt2";
            lblOpt2.Size = new Size(24, 25);
            lblOpt2.TabIndex = 7;
            lblOpt2.Text = "B";
            // 
            // txtOpt3
            // 
            txtOpt3.Location = new Point(80, 189);
            txtOpt3.Name = "txtOpt3";
            txtOpt3.Size = new Size(220, 31);
            txtOpt3.TabIndex = 12;
            // 
            // txtOpt4
            // 
            txtOpt4.Location = new Point(419, 189);
            txtOpt4.Name = "txtOpt4";
            txtOpt4.Size = new Size(220, 31);
            txtOpt4.TabIndex = 13;
            // 
            // txtOpt1
            // 
            txtOpt1.Location = new Point(80, 129);
            txtOpt1.Name = "txtOpt1";
            txtOpt1.Size = new Size(220, 31);
            txtOpt1.TabIndex = 10;
            // 
            // lblOpt4
            // 
            lblOpt4.AutoSize = true;
            lblOpt4.Location = new Point(367, 195);
            lblOpt4.Name = "lblOpt4";
            lblOpt4.Size = new Size(25, 25);
            lblOpt4.TabIndex = 9;
            lblOpt4.Text = "D";
            // 
            // lblOpt3
            // 
            lblOpt3.AutoSize = true;
            lblOpt3.Location = new Point(16, 195);
            lblOpt3.Name = "lblOpt3";
            lblOpt3.Size = new Size(23, 25);
            lblOpt3.TabIndex = 8;
            lblOpt3.Text = "C";
            // 
            // txtOpt2
            // 
            txtOpt2.Location = new Point(419, 126);
            txtOpt2.Name = "txtOpt2";
            txtOpt2.Size = new Size(220, 31);
            txtOpt2.TabIndex = 11;
            // 
            // CreateQuizForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 763);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "CreateQuizForm";
            Text = "CreateQuizForm";
            grpList.ResumeLayout(false);
            grpList.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpQuestion.ResumeLayout(false);
            grpQuestion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuizTitle;
        private TextBox txtQuizTitle;
        private GroupBox grpList;
        private Label lblQText;
        private TextBox txtQuestion;
        private Panel panel1;
        private Label lblOpt4;
        private Label lblOpt3;
        private Label lblOpt2;
        private Label lblOpt1;
        private TextBox txtOpt4;
        private TextBox txtOpt3;
        private TextBox txtOpt2;
        private TextBox txtOpt1;
        private Label lblCorrect;
        private ComboBox cmbCorrect;
        private Button btnSaveQuiz;
        private Button btnAddQuestion;
        private ListBox lstQuestions;
        private Label lblQCount;
        private GroupBox grpQuestion;
    }
}