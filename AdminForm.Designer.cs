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
            btnDeleteUser = new Button();
            btnAddUser = new Button();
            cmbRole = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            dgvUsers = new DataGridView();
            tabPage2 = new TabPage();
            btnDeleteSubject = new Button();
            btnAddSubject = new Button();
            cmbTeachers = new ComboBox();
            txtSubjectName = new TextBox();
            dgvSubjects = new DataGridView();
            tabPage3 = new TabPage();
            lstSubjects = new ListBox();
            lstStudents = new ListBox();
            btnDeleteGroup = new Button();
            btnAddGroup = new Button();
            txtGroupName = new TextBox();
            dgvGroups = new DataGridView();
            tabControlAdmin.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            tabPage3.SuspendLayout();
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
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(101, 249);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 23);
            btnDeleteUser.TabIndex = 5;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(6, 249);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(6, 220);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(5, 191);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 162);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(6, 6);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(240, 150);
            dgvUsers.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteSubject);
            tabPage2.Controls.Add(btnAddSubject);
            tabPage2.Controls.Add(cmbTeachers);
            tabPage2.Controls.Add(txtSubjectName);
            tabPage2.Controls.Add(dgvSubjects);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(635, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Subjects";
            tabPage2.UseVisualStyleBackColor = true;
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
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(6, 220);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(83, 23);
            btnAddSubject.TabIndex = 3;
            btnAddSubject.Text = "Add Subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click_1;
            // 
            // cmbTeachers
            // 
            cmbTeachers.FormattingEnabled = true;
            cmbTeachers.Location = new Point(6, 191);
            cmbTeachers.Name = "cmbTeachers";
            cmbTeachers.Size = new Size(121, 23);
            cmbTeachers.TabIndex = 2;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(6, 162);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(100, 23);
            txtSubjectName.TabIndex = 1;
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(6, 6);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(240, 150);
            dgvSubjects.TabIndex = 0;
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
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(251, 6);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(120, 94);
            lstStudents.TabIndex = 4;
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
            // btnAddGroup
            // 
            btnAddGroup.Location = new Point(5, 191);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(75, 23);
            btnAddGroup.TabIndex = 2;
            btnAddGroup.Text = "Add Group";
            btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // txtGroupName
            // 
            txtGroupName.Location = new Point(5, 162);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(100, 23);
            txtGroupName.TabIndex = 1;
            // 
            // dgvGroups
            // 
            dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroups.Location = new Point(5, 6);
            dgvGroups.Name = "dgvGroups";
            dgvGroups.Size = new Size(240, 150);
            dgvGroups.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private DataGridView dgvSubjects;
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