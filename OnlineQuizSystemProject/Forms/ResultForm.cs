using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ResultForm : Form
    {
        private readonly OnlineQuizSystemProject.Models.User _user;
        private readonly bool _isAdmin;
        public ResultForm(OnlineQuizSystemProject.Models.User user, bool isAdmin)
        {
            _user = user;
            _isAdmin = isAdmin;
            InitializeComponent();
            LoadResults();
        }
        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadResults()
        {
            listView.Items.Clear();
            listView.Columns.Clear();

            if (_isAdmin)
            {
                listView.Columns.Add("Student", 130);
                listView.Columns.Add("Quiz", 150);
                listView.Columns.Add("Total", 70);
                listView.Columns.Add("Obtained", 80);
                listView.Columns.Add("Percentage", 90);
                listView.Columns.Add("Date", 150);
            }
            else
            {
                listView.Columns.Add("Quiz", 200);
                listView.Columns.Add("Total", 80);
                listView.Columns.Add("Obtained", 90);
                listView.Columns.Add("Percentage", 100);
                listView.Columns.Add("Date", 200);
            }

            List<QuizResult> results = _isAdmin
                ? DataManager.GetResults()
                : DataManager.GetResultsForStudent(_user?.Username ?? "");

            if (results.Count == 0)
            {
                lblSummary.Text = "No quiz results found.";
                return;
            }

            int totalObtained = 0, totalMarks = 0;

            foreach (var r in results)
            {
                var item = new ListViewItem(_isAdmin ? r.StudentFullName : r.QuizTitle);
                if (_isAdmin) item.SubItems.Add(r.QuizTitle);
                item.SubItems.Add(r.TotalMarks.ToString());
                item.SubItems.Add(r.ObtainedMarks.ToString());
                item.SubItems.Add($"{r.Percentage:0.##}%");
                item.SubItems.Add(r.SubmittedAt.ToString("dd MMM yyyy HH:mm"));

                item.ForeColor = r.Percentage >= 75 ? Color.FromArgb(52, 211, 153)
                               : r.Percentage >= 50 ? Color.FromArgb(251, 191, 36)
                               : Color.FromArgb(248, 113, 113);

                listView.Items.Add(item);
                totalObtained += r.ObtainedMarks;
                totalMarks += r.TotalMarks;
            }

            double overallPct = totalMarks > 0
                ? Math.Round((totalObtained / (double)totalMarks) * 100, 2) : 0;

            lblSummary.Text = _isAdmin
                ? $"Total Attempts: {results.Count}  |  Overall Avg: {overallPct:0.##}%"
                : $"Total Marks: {totalMarks}  |  Obtained: {totalObtained}  |  Overall: {overallPct:0.##}%";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

