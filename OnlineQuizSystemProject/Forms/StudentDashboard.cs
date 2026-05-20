using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using OnlineQuizSystemProject.Helpers;
using OnlineQuizSystemProject.Models;
using System.Text;
using System.Windows.Forms;

namespace OnlineQuizSystemProject.Forms
{
    /// <summary>
    /// Dashboard form for logged-in students.
    /// Allows students to start a quiz by selecting from
    /// available quizzes and view their past results.
    /// </summary>
    public partial class StudentDashboard : Form
    {
        private readonly OnlineQuizSystemProject.Models.User _currentUser;

        /// <summary>
        /// Initializes the student dashboard with the logged-in
        /// user and displays a welcome message.
        /// </summary>
        public StudentDashboard(OnlineQuizSystemProject.Models.User user)
        {
            _currentUser = user;
            InitializeComponent();
            lblTitle.Text = $"Welcome, Student!";
        }
        /// <summary>
        /// Checks if any quizzes are available, opens QuizPickerForm
        /// for the student to choose a quiz, then launches QuizForm.
        /// </summary>
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            var quizzes = DataManager.GetQuizzes().ToList();
            if (quizzes.Count == 0)
            {
                MessageBox.Show("No quizzes are available yet. Please check back later.",
                    "No Quizzes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Open quiz picker dialog and only proceed if student made a selection
            using (var picker = new QuizPickerForm(quizzes))
            {
                if (picker.ShowDialog() == DialogResult.OK && picker.SelectedQuiz != null)
                {
                    var quizForm = new QuizForm(_currentUser, picker.SelectedQuiz);
                    quizForm.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Opens the ResultForm in student mode showing
        /// only this student's own quiz history.
        /// </summary>
        private void btnViewResult_Click(object sender, EventArgs e)
        {
            var resultForm = new ResultForm(_currentUser, isAdmin: false);
            resultForm.ShowDialog();
        }

        /// <summary>
        /// Logs out the student by closing the dashboard
        /// and returning to the login form.
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

