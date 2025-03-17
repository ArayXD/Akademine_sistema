namespace AcademicSystem
{
    partial class AdminForm
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
            tabControlAdmin = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dgvUsers = new DataGridView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cmbRole = new ComboBox();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            dataGridView1 = new DataGridView();
            txtSubjectName = new TextBox();
            cmbTeachers = new ComboBox();
            btnAddSubject = new Button();
            btnDeleteSubject = new Button();
            dgvGroups = new DataGridView();
            txtGroupName = new TextBox();
            btnAddGroup = new Button();
            btnDeleteGroup = new Button();
            lstStudents = new ListBox();
            lstSubjects = new ListBox();
            tabControlAdmin.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
            SuspendLayout();
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabPage1);
            tabControlAdmin.Controls.Add(tabPage2);
            tabControlAdmin.Controls.Add(tabPage3);
            tabControlAdmin.Location = new Point(3, 12);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(643, 388);
            tabControlAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeleteUser);
            tabPage1.Controls.Add(btnAddUser);
            tabPage1.Controls.Add(cmbRole);
            tabPage1.Controls.Add(txtLastName);
            tabPage1.Controls.Add(txtFirstName);
            tabPage1.Controls.Add(dgvUsers);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(635, 360);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteSubject);
            tabPage2.Controls.Add(btnAddSubject);
            tabPage2.Controls.Add(cmbTeachers);
            tabPage2.Controls.Add(txtSubjectName);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(635, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Subjects";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lstSubjects);
            tabPage3.Controls.Add(lstStudents);
            tabPage3.Controls.Add(btnDeleteGroup);
            tabPage3.Controls.Add(btnAddGroup);
            tabPage3.Controls.Add(txtGroupName);
            tabPage3.Controls.Add(dgvGroups);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(635, 360);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Groups";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(6, 6);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(240, 150);
            dgvUsers.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 162);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += textBox1_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(5, 191);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(6, 220);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 3;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(6, 249);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += button1_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(101, 249);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 23);
            btnDeleteUser.TabIndex = 5;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(6, 162);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(100, 23);
            txtSubjectName.TabIndex = 1;
            // 
            // cmbTeachers
            // 
            cmbTeachers.FormattingEnabled = true;
            cmbTeachers.Location = new Point(6, 191);
            cmbTeachers.Name = "cmbTeachers";
            cmbTeachers.Size = new Size(121, 23);
            cmbTeachers.TabIndex = 2;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(6, 220);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(83, 23);
            btnAddSubject.TabIndex = 3;
            btnAddSubject.Text = "Add Subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Location = new Point(95, 220);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(90, 23);
            btnDeleteSubject.TabIndex = 4;
            btnDeleteSubject.Text = "Delete Subject";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            // 
            // dgvGroups
            // 
            dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroups.Location = new Point(5, 6);
            dgvGroups.Name = "dgvGroups";
            dgvGroups.Size = new Size(240, 150);
            dgvGroups.TabIndex = 0;
            // 
            // txtGroupName
            // 
            txtGroupName.Location = new Point(5, 162);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(100, 23);
            txtGroupName.TabIndex = 1;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Location = new Point(5, 191);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(75, 23);
            btnAddGroup.TabIndex = 2;
            btnAddGroup.Text = "Add Group";
            btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGroup
            // 
            btnDeleteGroup.Location = new Point(86, 191);
            btnDeleteGroup.Name = "btnDeleteGroup";
            btnDeleteGroup.Size = new Size(84, 23);
            btnDeleteGroup.TabIndex = 3;
            btnDeleteGroup.Text = "Delete Group";
            btnDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(251, 6);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(120, 94);
            lstStudents.TabIndex = 4;
            // 
            // lstSubjects
            // 
            lstSubjects.FormattingEnabled = true;
            lstSubjects.ItemHeight = 15;
            lstSubjects.Location = new Point(377, 6);
            lstSubjects.Name = "lstSubjects";
            lstSubjects.Size = new Size(120, 94);
            lstSubjects.TabIndex = 5;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlAdmin);
            Name = "AdminForm";
            Text = "AdminForm";
            tabControlAdmin.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgvUsers;
        private TextBox txtFirstName;
        private Button btnAddUser;
        private ComboBox cmbRole;
        private TextBox txtLastName;
        private Button btnDeleteUser;
        private ComboBox cmbTeachers;
        private TextBox txtSubjectName;
        private DataGridView dataGridView1;
        private Button btnDeleteSubject;
        private Button btnAddSubject;
        private DataGridView dgvGroups;
        private ListBox lstStudents;
        private Button btnDeleteGroup;
        private Button btnAddGroup;
        private TextBox txtGroupName;
        private ListBox lstSubjects;
    }
}