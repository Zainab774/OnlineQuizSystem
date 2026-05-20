using OnlineQuizSystemProject.Helpers;
using OnlineQuizSystemProject.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineQuizSystemProject.Forms
{
    /// <summary>
    /// Form that allows the teacher to view, rename,
    /// and delete existing quizzes. Provides full CRUD
    /// management for the Quiz entity.
    /// </summary>
    public partial class ManageQuizzesForm : Form
    {
        /// <summary>
        /// Initializes the form and loads all quizzes into the grid.
        /// </summary>
        public ManageQuizzesForm()
        {
            InitializeComponent();
            SetupGrid();
            LoadQuizzes();
        }

        /// <summary>
        /// Configures DataGridView columns for displaying quiz data.
        /// QuizId column is hidden and used only for delete and rename operations.
        /// </summary>
        private void SetupGrid()
        {
            dgvQuizzes.Columns.Clear();

            // Hidden ID column used internally for delete/rename
            dgvQuizzes.Columns.Add("QuizId", "ID");
            dgvQuizzes.Columns["QuizId"]!.Visible = false;

            dgvQuizzes.Columns.Add("Title", "Quiz Title");
            dgvQuizzes.Columns.Add("Questions", "Questions");
            dgvQuizzes.Columns.Add("CreatedBy", "Created By");

            dgvQuizzes.Columns["Title"]!.Width = 250;
            dgvQuizzes.Columns["Questions"]!.Width = 100;
            dgvQuizzes.Columns["CreatedBy"]!.Width = 120;
        }

        /// <summary>
        /// Clears and reloads the DataGridView with
        /// all quizzes fetched from DataManager.
        /// </summary>
        private void LoadQuizzes()
        {
            dgvQuizzes.Rows.Clear();
            foreach (var q in DataManager.GetQuizzes())
            {
                dgvQuizzes.Rows.Add(
                    q.QuizId ?? "",
                    q.Title ?? "",
                    q.Questions.Count + " questions",
                    q.CreatedBy ?? ""
                );
            }
        }
        /// <summary>
        /// Prompts teacher to enter a new title for
        /// the selected quiz and saves the updated title.
        /// </summary>

        private void btnRename_Click_1(object sender, EventArgs e)
        {
            if (dgvQuizzes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a quiz to rename.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string oldTitle = dgvQuizzes.SelectedRows[0].Cells["Title"].Value.ToString() ?? "";
            string id = dgvQuizzes.SelectedRows[0].Cells["QuizId"].Value.ToString() ?? "";

            // Prompt teacher to enter the new quiz title
            string newTitle = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter new title for the quiz:",
                "Rename Quiz",
                oldTitle);

            if (!string.IsNullOrWhiteSpace(newTitle) && newTitle != oldTitle)
            {
                DataManager.UpdateQuizTitle(id, newTitle);
                LoadQuizzes();
                MessageBox.Show("Quiz renamed successfully.",
                    "Renamed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Deletes the selected quiz after user confirmation.
        /// Refreshes the grid after successful deletion.
        /// </summary>
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvQuizzes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a quiz to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = dgvQuizzes.SelectedRows[0].Cells["Title"].Value.ToString() ?? "";
            string id = dgvQuizzes.SelectedRows[0].Cells["QuizId"].Value.ToString() ?? "";

            // Ask for confirmation before permanently deleting
            var confirm = MessageBox.Show(
                $"Are you sure you want to delete \"{title}\"?\nThis cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DataManager.DeleteQuiz(id);
                LoadQuizzes();
                MessageBox.Show("Quiz deleted successfully.",
                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }
    }
}