namespace OnlineQuizSystemProject.Forms
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            lblTitle = new Label();
            lblSummary = new Label();
            listView = new ListView();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(254, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊  Quiz Results";
            // 
            // lblSummary
            // 
            lblSummary.BackColor = Color.Transparent;
            lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(148, 163, 184);
            lblSummary.Location = new Point(50, 82);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(700, 30);
            lblSummary.TabIndex = 1;
            // 
            // listView
            // 
            listView.BackColor = Color.FromArgb(30, 41, 59);
            listView.BorderStyle = BorderStyle.FixedSingle;
            listView.ForeColor = Color.White;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Location = new Point(50, 115);
            listView.Name = "listView";
            listView.Size = new Size(700, 220);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(71, 85, 105);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(340, 360);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 38);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblSummary);
            Controls.Add(listView);
            Controls.Add(btnClose);
            Name = "ResultForm";
            Text = "ResultForm";
            Load += ResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListView listView;
        private Button btnClose;
        private Label lblSummary;
    }
}