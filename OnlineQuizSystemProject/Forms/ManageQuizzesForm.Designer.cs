namespace OnlineQuizSystemProject.Forms
{
    partial class ManageQuizzesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvQuizzes = new DataGridView();
            btnRename = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(99, 102, 241);
            lblTitle.Location = new Point(76, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Quizzes";
            // 
            // dgvQuizzes
            // 
            dgvQuizzes.AllowUserToAddRows = false;
            dgvQuizzes.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvQuizzes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuizzes.Location = new Point(20, 60);
            dgvQuizzes.Name = "dgvQuizzes";
            dgvQuizzes.ReadOnly = true;
            dgvQuizzes.RowHeadersVisible = false;
            dgvQuizzes.RowHeadersWidth = 62;
            dgvQuizzes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuizzes.Size = new Size(560, 280);
            dgvQuizzes.TabIndex = 1;
            // 
            // btnRename
            // 
            btnRename.BackColor = Color.MediumSlateBlue;
            btnRename.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRename.ForeColor = Color.White;
            btnRename.Location = new Point(20, 360);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(203, 38);
            btnRename.TabIndex = 2;
            btnRename.Text = "Rename Selected Quiz";
            btnRename.UseVisualStyleBackColor = false;
            btnRename.Click += btnRename_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(230, 360);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(222, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Selected Quiz";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // ManageQuizzesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnRename);
            Controls.Add(dgvQuizzes);
            Controls.Add(lblTitle);
            Name = "ManageQuizzesForm";
            Text = "ManageQuizzesForm";
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvQuizzes;
        private Button btnRename;
        private Button btnDelete;
    }
}