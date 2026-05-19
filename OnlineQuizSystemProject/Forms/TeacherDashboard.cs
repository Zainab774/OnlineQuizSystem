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
    public partial class TeacherDashboard : Form
    {
        private readonly OnlineQuizSystemProject.Models.User _admin;
        public TeacherDashboard(OnlineQuizSystemProject.Models.User admin)
        {
            _admin = admin;
            InitializeComponent();
            lblTitle.Text = $"Welcome, Teacher!";
        }
        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            var createForm = new CreateQuizForm(_admin);
            createForm.ShowDialog();
        }
        private void btnViewResult_Click(object sender, EventArgs e)
        {
            var resultForm = new ResultForm(_admin, isAdmin: true);
            resultForm.ShowDialog();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
