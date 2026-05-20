using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using OnlineQuizSystemProject.Models;
using System.Text;
using System.Windows.Forms;

namespace OnlineQuizSystemProject.Forms
{
    /// <summary>
    /// Dashboard form for the logged-in admin/teacher.
    /// Allows teacher to create new quizzes and view
    /// all student results across the system.
    /// </summary>
    public partial class TeacherDashboard : Form
    {
        private readonly OnlineQuizSystemProject.Models.User _admin;

        /// <summary>
        /// Initializes the teacher dashboard with the logged-in
        /// admin user and displays a welcome message.
        /// </summary>
        public TeacherDashboard(OnlineQuizSystemProject.Models.User admin)
        {
            _admin = admin;
            InitializeComponent();
            lblTitle.Text = $"Welcome, Teacher!";
        }

        /// <summary>
        /// Opens the CreateQuizForm as a dialog so the teacher
        /// can build and save a new quiz with questions.
        /// </summary>
        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            var createForm = new CreateQuizForm(_admin);
            createForm.ShowDialog();
        }

        /// <summary>
        /// Opens the ResultForm in admin mode showing
        /// all students results across all quizzes.
        /// </summary>
        private void btnViewResult_Click(object sender, EventArgs e)
        {
            var resultForm = new ResultForm(_admin, isAdmin: true);
            resultForm.ShowDialog();
        }

        /// <summary>
        /// Logs out the teacher by closing the dashboard
        /// and returning to the login form.
        /// </summary>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the ManageQuizzesForm so teacher can
        /// view, rename and delete existing quizzes.
        /// </summary>
        private void btnManageQuizzes_Click(object sender, EventArgs e)
        {
            var manageForm = new ManageQuizzesForm();
            manageForm.ShowDialog();
        }
    }
}
