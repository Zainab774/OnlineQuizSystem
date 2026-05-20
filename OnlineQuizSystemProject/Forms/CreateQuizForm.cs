using OnlineQuizSystemProject.Helpers;
using OnlineQuizSystemProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnlineQuizSystemProject.Forms
{
    /// <summary>
    /// Form that allows the admin/teacher to create a new quiz
    /// by entering a title and adding multiple choice questions
    /// one by one before saving to DataManager.
    /// </summary>
    public partial class CreateQuizForm : Form
    {
        private readonly User _admin;
        private readonly List<Question> _questions = new List<Question>();

        /// <summary>
        /// Initializes the form with the logged-in admin user
        /// and loads the current question list.
        /// </summary>
        public CreateQuizForm(User admin)
        {
            _admin = admin;
            InitializeComponent();
            RefreshQuestionList();
        }

        /// <summary>
        /// Clears and reloads the question listbox with all
        /// currently added questions and updates the question count label.
        /// </summary>
        private void RefreshQuestionList()
        {
            lstQuestions.Items.Clear();
            for (int i = 0; i < _questions.Count; i++)
                lstQuestions.Items.Add($"Q{i + 1}: {_questions[i].QuestionText}");

            lblQCount.Text = $"Questions added: {_questions.Count}";
        }

        /// <summary>
        /// Validates quiz title and question count, then creates
        /// a new Quiz object and saves it via DataManager.
        /// </summary>
        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {

            string title = txtQuizTitle.Text.Trim();
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a quiz title.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_questions.Count == 0)
            {
                MessageBox.Show("Please add at least one question before saving.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quiz = new Quiz
            {
                QuizId = Guid.NewGuid().ToString(),
                Title = title,
                CreatedBy = _admin.Username,
                CreatedAt = DateTime.Now,
                Questions = new List<Question>(_questions)
            };

            DataManager.AddQuiz(quiz);

            MessageBox.Show($"Quiz \"{title}\" saved successfully with {_questions.Count} question(s)!",
                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        /// <summary>
        /// Validates all question fields and correct answer selection,
        /// then adds the new Question to the list and refreshes the display.
        /// </summary>
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            string qText = txtQuestion.Text.Trim();
            string opt1 = txtOpt1.Text.Trim();
            string opt2 = txtOpt2.Text.Trim();
            string opt3 = txtOpt3.Text.Trim();
            string opt4 = txtOpt4.Text.Trim();

            if (string.IsNullOrEmpty(qText) || string.IsNullOrEmpty(opt1) ||
                string.IsNullOrEmpty(opt2) || string.IsNullOrEmpty(opt3) ||
                string.IsNullOrEmpty(opt4))
            {
                MessageBox.Show("Please fill in the question and all four options.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Get the correct answer index from dropdown (0=A, 1=B, 2=C, 3=D)
            int correctIdx = cmbCorrect.SelectedIndex;
            if (correctIdx < 0)
            {
                MessageBox.Show("Please select the correct answer option.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _questions.Add(new Question
            {
                QuestionText = qText,
                Options = new List<string> { opt1, opt2, opt3, opt4 },
                CorrectOptionIndex = correctIdx
            });

            // Clear all input fields after adding so user can enter next question
            txtQuestion.Clear(); txtOpt1.Clear(); txtOpt2.Clear();
            txtOpt3.Clear(); txtOpt4.Clear(); cmbCorrect.SelectedIndex = -1;
            txtQuestion.Focus();

            RefreshQuestionList();
        }

    }
}

