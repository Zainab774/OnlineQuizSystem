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
    public partial class StudentDashboard : Form
    {
        private readonly OnlineQuizSystemProject.Models.User _currentUser;
        public StudentDashboard(OnlineQuizSystemProject.Models.User user)
        {
            _currentUser = user;
            InitializeComponent();
            lblTitle.Text = $"Welcome, Student!";
        }
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            var quizzes = DataManager.GetQuizzes().ToList();
            if (quizzes.Count == 0)
            {
                MessageBox.Show("No quizzes are available yet. Please check back later.",
                    "No Quizzes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Let student pick a quiz
            using (var picker = new QuizPickerForm(quizzes))
            {
                if (picker.ShowDialog() == DialogResult.OK && picker.SelectedQuiz != null)
                {
                    var quizForm = new QuizForm(_currentUser, picker.SelectedQuiz);
                    quizForm.ShowDialog();
                }
            }
        }
        private void btnViewResult_Click(object sender, EventArgs e)
        {
            var resultForm = new ResultForm(_currentUser, isAdmin: false);
            resultForm.ShowDialog();
        }

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
    

