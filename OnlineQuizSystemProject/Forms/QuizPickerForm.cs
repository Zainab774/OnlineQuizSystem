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
    public partial class QuizPickerForm : Form
    {
        public Quiz? SelectedQuiz { get; private set; }

        private ListBox? lstQuizzes;
        private Button? btnSelect;
        private Button? btnCancel;
        private readonly List<Quiz> _quizzes;
        public QuizPickerForm(List<Quiz> quizzes)
        {
            InitializeComponent();
            _quizzes = quizzes ?? new List<Quiz>();
            Build();
        }
        private void Build()
        {
            this.Text = "Select a Quiz";
            this.Size = new Size(450, 420);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(15, 23, 42);

            // Search box for filtering quizzes by title in real time
            var txtSearch = new TextBox
            {
                PlaceholderText = "Search quizzes...",
                Size = new Size(400, 32),
                Location = new Point(20, 58),
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(30, 41, 59),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };


            var lbl = new Label
            {
                Text = "📝  Choose a Quiz to Attempt:",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(99, 102, 241),
                AutoSize = false,
                Size = new Size(400, 35),
                Location = new Point(20, 15)
            };

            lstQuizzes = new ListBox
            {
                Size = new Size(400, 200),
                Location = new Point(20, 100),
                BackColor = Color.FromArgb(30, 41, 59),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F),
                BorderStyle = BorderStyle.FixedSingle,
                ItemHeight = 35
            };

            foreach (var q in _quizzes)
                lstQuizzes.Items.Add($"  📋  {q.Title}  ({q.Questions.Count} questions)");

            if (lstQuizzes.Items.Count > 0) lstQuizzes.SelectedIndex = 0;


            // Filter quiz list in real time as student types
            txtSearch.TextChanged += (s, e) =>
            {
                string query = txtSearch.Text.Trim().ToLower();
                lstQuizzes.Items.Clear();

                var filtered = string.IsNullOrEmpty(query)
                    ? _quizzes
                    : _quizzes.FindAll(q =>
                        q.Title!.ToLower().Contains(query));

                foreach (var q in filtered)
                    lstQuizzes.Items.Add($"  📋  {q.Title}  ({q.Questions.Count} questions)");

                if (lstQuizzes.Items.Count > 0) lstQuizzes.SelectedIndex = 0;
            };

            btnSelect = new Button
            {
                Text = "▶  Start Quiz",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(16, 185, 129),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 42),
                Location = new Point(20, 275),
                Cursor = Cursors.Hand
            };
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.Click += (s, e) =>
            {
                if (lstQuizzes.SelectedIndex < 0) return;

                // Match selected item back to correct quiz from filtered list
                string query = txtSearch.Text.Trim().ToLower();
                var filtered = string.IsNullOrEmpty(query)
                    ? _quizzes
                    : _quizzes.FindAll(q =>
                        q.Title!.ToLower().Contains(query));

                SelectedQuiz = _quizzes[lstQuizzes.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            btnCancel = new Button
            {
                Text = "✖  Cancel",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(71, 85, 105),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(140, 42),
                Location = new Point(220, 275),
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.AddRange(new Control[] { lbl, txtSearch, lstQuizzes, btnSelect, btnCancel });
        }
    }
}
    
