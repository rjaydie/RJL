namespace Draft
{
    partial class dashboard
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
            btnRegisterStudent = new Button();
            btnStudentList = new Button();
            SuspendLayout();
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.BackColor = SystemColors.ActiveBorder;
            btnRegisterStudent.FlatStyle = FlatStyle.Flat;
            btnRegisterStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegisterStudent.Location = new Point(118, 180);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(248, 80);
            btnRegisterStudent.TabIndex = 0;
            btnRegisterStudent.Text = "REGISTER STUDENT";
            btnRegisterStudent.UseVisualStyleBackColor = false;
            btnRegisterStudent.Click += btnRegisterStudent_Click;
            // 
            // btnStudentList
            // 
            btnStudentList.BackColor = SystemColors.ActiveBorder;
            btnStudentList.FlatStyle = FlatStyle.Flat;
            btnStudentList.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStudentList.Location = new Point(426, 180);
            btnStudentList.Name = "btnStudentList";
            btnStudentList.Size = new Size(243, 80);
            btnStudentList.TabIndex = 1;
            btnStudentList.Text = "STUDENT LIST";
            btnStudentList.UseVisualStyleBackColor = false;
            btnStudentList.Click += btnStudentList_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStudentList);
            Controls.Add(btnRegisterStudent);
            Name = "dashboard";
            Text = "dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterStudent;
        private Button btnStudentList;
    }
}