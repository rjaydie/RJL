namespace Draft
{
    partial class StudentList
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
            label1 = new Label();
            txtSearch = new TextBox();
            dgvStudents = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            btnSaveRecord = new Button();
            btnDeleteRecord = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(84, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MASTER LIST";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(84, 180);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(347, 39);
            txtSearch.TabIndex = 1;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(84, 263);
            dgvStudents.Margin = new Padding(4, 5, 4, 5);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(851, 598);
            dgvStudents.TabIndex = 3;
            dgvStudents.CellClick += dgvStudents_CellClick;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(1114, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(398, 32);
            label2.TabIndex = 4;
            label2.Text = "UPDATE STUDENT INFORMATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(1114, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 32);
            label3.TabIndex = 5;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(1021, 242);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 6;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(1024, 300);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 7;
            label5.Text = "Last Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(1064, 363);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 8;
            label6.Text = "Course:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(1057, 422);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 32);
            label7.TabIndex = 9;
            label7.Text = "Section:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(1096, 480);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 32);
            label8.TabIndex = 10;
            label8.Text = "Age:";
            label8.Click += label8_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(1167, 175);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(347, 39);
            txtID.TabIndex = 11;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(1167, 237);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(347, 39);
            txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(1167, 295);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(347, 39);
            txtLastName.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F);
            txtAge.Location = new Point(1167, 475);
            txtAge.Margin = new Padding(4, 5, 4, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(347, 39);
            txtAge.TabIndex = 16;
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 12F);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "ACT", "BSOA", "HM" });
            cmbCourse.Location = new Point(1167, 358);
            cmbCourse.Margin = new Padding(4, 5, 4, 5);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(347, 40);
            cmbCourse.TabIndex = 17;
            // 
            // cmbSection
            // 
            cmbSection.Font = new Font("Segoe UI", 12F);
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "1A", "1B", "1C", "1D" });
            cmbSection.Location = new Point(1167, 417);
            cmbSection.Margin = new Padding(4, 5, 4, 5);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(347, 40);
            cmbSection.TabIndex = 18;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.BackColor = SystemColors.ActiveBorder;
            btnSaveRecord.FlatStyle = FlatStyle.Flat;
            btnSaveRecord.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSaveRecord.Location = new Point(1167, 548);
            btnSaveRecord.Margin = new Padding(4, 5, 4, 5);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(349, 60);
            btnSaveRecord.TabIndex = 19;
            btnSaveRecord.Text = "SAVE RECORD";
            btnSaveRecord.UseVisualStyleBackColor = false;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.BackColor = SystemColors.ActiveBorder;
            btnDeleteRecord.FlatStyle = FlatStyle.Flat;
            btnDeleteRecord.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteRecord.Location = new Point(1167, 618);
            btnDeleteRecord.Margin = new Padding(4, 5, 4, 5);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(349, 60);
            btnDeleteRecord.TabIndex = 20;
            btnDeleteRecord.Text = "DELETE RECORD";
            btnDeleteRecord.UseVisualStyleBackColor = false;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ActiveBorder;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.Location = new Point(763, 100);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(173, 60);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveBorder;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.Location = new Point(441, 175);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(173, 60);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 982);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteRecord);
            Controls.Add(btnSaveRecord);
            Controls.Add(cmbSection);
            Controls.Add(cmbCourse);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvStudents);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StudentList";
            Text = "StudentList";
            Load += StudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgvStudents;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private Button btnSaveRecord;
        private Button btnDeleteRecord;
        private Button btnRefresh;
        private Button btnSearch;
    }
}