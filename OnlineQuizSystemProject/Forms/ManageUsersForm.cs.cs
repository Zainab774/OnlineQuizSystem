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
    // <summary>
    /// Form that allows the admin to view, add, edit,
    /// and delete student user accounts. Provides full
    /// CRUD management for the User entity.
    /// </summary>
    public partial class ManageUsersForm : Form
    {
        /// <summary>
        /// Initializes the form, sets up grid columns,
        /// and loads all users into the DataGridView.
        /// </summary>
        public ManageUsersForm()
        {
            InitializeComponent();
            SetupGrid();
            LoadUsers();
        }
        /// <summary>
        /// Configures DataGridView columns for displaying
        /// user data. Passwords are never shown on screen.
        /// </summary>
        private void SetupGrid()
        {
            dgvUsers.Columns.Clear();
            dgvUsers.Columns.Add("Username", "Username");
            dgvUsers.Columns.Add("FullName", "Full Name");
            dgvUsers.Columns.Add("Role", "Role");

            dgvUsers.Columns["Username"]!.Width = 200;
            dgvUsers.Columns["FullName"]!.Width = 300;
            dgvUsers.Columns["Role"]!.Width = 150;

            dgvUsers.ReadOnly = true;
            dgvUsers.MultiSelect = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Clears and reloads the DataGridView with all
        /// users fetched from DataManager.
        /// </summary>
        private void LoadUsers()
        {
            dgvUsers.Rows.Clear();
            foreach (var u in DataManager.GetUsers())
            {
                dgvUsers.Rows.Add(
                    u.Username ?? "",
                    u.FullName ?? "",
                    u.Role ?? ""
                );
            }
            lblCount.Text = $"Total users: {DataManager.GetUsers().Count}";
        }
        /// <summary>
        /// Validates all input fields then adds a new student
        /// user via DataManager. Checks for duplicate usernames.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in username, full name, and password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate username before adding
            var existing = DataManager.GetUsers().Find(u =>
                string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));

            if (existing != null)
            {
                MessageBox.Show("A user with that username already exists.",
                    "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataManager.AddUser(new OnlineQuizSystemProject.Models.User
            {
                Username = username,
                FullName = fullName,
                Password = password,
                Role = "student"
            });

            ClearInputs();
            LoadUsers();
            MessageBox.Show("User added successfully.",
                "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Loads the selected user's data into the input
        /// fields so the admin can modify and save changes.
        /// Username field is locked during edit mode.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString() ?? "";

            var user = DataManager.GetUsers().Find(u =>
                string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));

            if (user == null) return;

            // Populate input fields with selected user's current data
            txtUsername.Text = user.Username;
            txtFullName.Text = user.FullName;
            txtPassword.Text = user.Password;

            // Lock username — only name and password can be changed
            txtUsername.ReadOnly = true;
            btnSaveEdit.Visible = true;
            btnAdd.Enabled = false;
        }
        /// <summary>
        /// Saves updated full name and password for the user
        /// currently loaded in the input fields.
        /// </summary>
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newFullName = txtFullName.Text.Trim();
            string newPassword = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(newFullName) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Full name and password cannot be empty.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataManager.UpdateUser(username, newFullName, newPassword);

            // Exit edit mode and restore form to normal state
            ClearInputs();
            LoadUsers();
            btnSaveEdit.Visible = false;
            btnAdd.Enabled = true;
            txtUsername.ReadOnly = false;

            MessageBox.Show("User updated successfully.",
                "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Deletes the selected user after confirmation.
        /// The admin account is protected and cannot be deleted.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString() ?? "";

            // Prevent accidental deletion of the admin account
            if (string.Equals(username, "admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("The admin account cannot be deleted.",
                    "Protected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete \"{username}\"?\nThis cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DataManager.DeleteUser(username);
                LoadUsers();
                MessageBox.Show("User deleted successfully.",
                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Filters the DataGridView in real time as the
        /// admin types in the search box.
        /// </summary>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();
            dgvUsers.Rows.Clear();

            foreach (var u in DataManager.GetUsers())
            {
                // Include row only if username or full name matches search text
                if ((u.Username ?? "").ToLower().Contains(search) ||
                    (u.FullName ?? "").ToLower().Contains(search))
                {
                    dgvUsers.Rows.Add(u.Username, u.FullName, u.Role);
                }
            }
        }
            /// <summary>
            /// Clears all three input text fields.
            /// </summary>
        private void ClearInputs()
        {
            txtUsername.Text = "";
            txtFullName.Text = "";
            txtPassword.Text = "";
        }
     }
    }

