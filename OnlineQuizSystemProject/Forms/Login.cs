using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using OnlineQuizSystemProject.Helpers;
using OnlineQuizSystemProject.Forms;
using OnlineQuizSystemProject.Models;
using System.Windows.Forms;

namespace OnlineQuizSystemProject;

/// <summary>
/// Login form. Authenticates the user via DataManager
/// and routes them to TeacherDashboard or StudentDashboard
/// based on their role.
/// </summary>

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    // <summary>
    /// Validates username and password inputs, calls DataManager.Authenticate,
    /// then opens the appropriate dashboard based on user role.
    /// </summary>
    private void btnLogin_Click(object sender, EventArgs e)
    {

        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.");
            return;
        }

        OnlineQuizSystemProject.Models.User? user = DataManager.Authenticate(username, password);

        if (user == null)
        {
            MessageBox.Show("Invalid username or password. Please try again.");
            txtPassword.Clear();
            txtPassword.Focus();
            return;
        }

        this.Hide();

        if (user.Role == "admin")
        {
            var teacherDash = new TeacherDashboard(user);
            teacherDash.FormClosed += (s, args) => { this.Show(); ResetForm(); };
            teacherDash.Show();
        }
        else
        {
            var studentDash = new StudentDashboard(user);
            studentDash.FormClosed += (s, args) => { this.Show(); ResetForm(); };
            studentDash.Show();
        }
    }

    /// <summary>
    /// Clears username and password fields and returns focus to username box.
    /// </summary>
    private void ResetForm()
    {
        txtUsername.Clear();
        txtPassword.Clear();
        txtUsername.Focus();
    }
    private void txtUsername_TextChanged(object sender, EventArgs e)
    {

    }
    private void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }
    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
    }
}


