namespace AcademicSystem
{
    partial class TeacherForm
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
            cmbSubjects = new ComboBox();
            dgvStudents = new DataGridView();
            txtGrade = new TextBox();
            btnSaveGrade = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // cmbSubjects
            // 
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(12, 12);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(121, 23);
            cmbSubjects.TabIndex = 0;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 41);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(240, 150);
            dgvStudents.TabIndex = 1;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(12, 197);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 2;
            // 
            // btnSaveGrade
            // 
            btnSaveGrade.Location = new Point(177, 197);
            btnSaveGrade.Name = "btnSaveGrade";
            btnSaveGrade.Size = new Size(75, 23);
            btnSaveGrade.TabIndex = 3;
            btnSaveGrade.Text = "Save";
            btnSaveGrade.UseVisualStyleBackColor = true;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveGrade);
            Controls.Add(txtGrade);
            Controls.Add(dgvStudents);
            Controls.Add(cmbSubjects);
            Name = "TeacherForm";
            Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSubjects;
        private DataGridView dgvStudents;
        private TextBox txtGrade;
        private Button btnSaveGrade;
    }
}