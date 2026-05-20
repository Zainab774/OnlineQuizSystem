using OnlineQuizSystemProject.Helpers;
using OnlineQuizSystemProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace OnlineQuizSystemProject.Forms
{
    /// <summary>
    /// Form that displays quiz questions one by one to the student.
    /// Tracks selected answers, handles navigation between questions,
    /// and calculates and saves the final score on submission.
    /// </summary>
    public partial class QuizForm : Form
    {
        private readonly User _student;
        private readonly Quiz _quiz;
        private int _currentIndex = 0;
        private readonly int[] _answers;   // -1 = not answered

        /// <summary>
        /// Initializes the quiz form for a specific student and quiz.
        /// Sets up answer tracking array and loads the first question.
        /// </summary>
        public QuizForm(User student, Quiz quiz)
        {
            _student = student;
            _quiz = quiz;
            _answers = new int[quiz.Questions.Count];
            for (int i = 0; i < _answers.Length; i++) _answers[i] = -1;

            InitializeComponent();
            LoadQuestion();
        }

        /// <summary>
        /// Loads the current question onto the form including question text,
        /// radio button options, progress bar, and navigation button visibility.
        /// </summary>
        private void LoadQuestion()
        {
            var q = _quiz.Questions[_currentIndex];
            int total = _quiz.Questions.Count;


            lblTitle.Text = _quiz.Title;
            lblQuestion.Text = q.QuestionText;

            // Progress bar
            progressBar.Maximum = total;
            progressBar.Value = _currentIndex + 1;

            // Clear only RadioButtons, not the buttons
            var radios = this.Controls.OfType<RadioButton>().ToList();
            foreach (var r in radios) this.Controls.Remove(r);

            for (int i = 0; i < q.Options.Count; i++)
            {
                int idx = i;
                var radio = new RadioButton
                {
                    Text = $"  {(char)('A' + i)}.  {q.Options[i]}",
                    Font = new Font("Segoe UI", 11F),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(30, 41, 59),
                    AutoSize = false,
                    Size = new Size(620, 46),
                    Location = new Point(80, 220+ i * 56),
                    Cursor = Cursors.Hand,
                    Tag = idx
                };
                // Restore student's previously selected answer if they navigate back
                if (_answers[_currentIndex] == idx) radio.Checked = true;

                radio.CheckedChanged += (s, e) =>
                {
                    if (s is RadioButton rb && rb.Checked) _answers[_currentIndex] = idx;
                };

                this.Controls.Add(radio);
            }

            // Show Previous only if not on first question, show Submit only on last question
            btnPrevious.Enabled = _currentIndex > 0;
            bool isLast = _currentIndex == total - 1;
            btnNext.Visible = !isLast;
            btnSubmit.Visible = isLast;
        }

        /// <summary>
        /// Moves to the next question if not already on the last one.
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_currentIndex < _quiz.Questions.Count - 1)
            {
                _currentIndex++;
                LoadQuestion();
            }
        }

        /// <summary>
        /// Moves back to the previous question if not on the first one.
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                LoadQuestion();
            }
        }

        /// <summary>
        /// Warns if any questions are unanswered, then calculates
        /// the score, saves the result via DataManager, and closes the form.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Count how many questions the student skipped
            int unanswered = 0;
            for (int i = 0; i < _answers.Length; i++)
                if (_answers[i] == -1) unanswered++;

            if (unanswered > 0)
            {
                var res = MessageBox.Show(
                    $"You have {unanswered} unanswered question(s).\nDo you still want to submit?",
                    "Unanswered Questions",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No) return;
            }

            // Compare each answer against correct option index to calculate score
            int obtained = 0;
            for (int i = 0; i < _quiz.Questions.Count; i++)
                if (_answers[i] == _quiz.Questions[i].CorrectOptionIndex) obtained++;

            int total = _quiz.Questions.Count;
                // Guard against divide-by-zero if quiz somehow has no questions
            double pct = total > 0 ? Math.Round((obtained / (double)total) * 100, 2) : 0;

            var result = new QuizResult
            {
                ResultId = Guid.NewGuid().ToString(),
                StudentUsername = _student.Username,
                StudentFullName = _student.FullName,
                QuizId = _quiz.QuizId,
                QuizTitle = _quiz.Title,
                TotalMarks = total,
                ObtainedMarks = obtained,
                Percentage = pct,
                SubmittedAt = DateTime.Now
            };

            DataManager.AddResult(result);

            MessageBox.Show(
                $"Quiz submitted!\n\nObtained: {obtained}/{total}  ({pct}%)",
                "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

    
