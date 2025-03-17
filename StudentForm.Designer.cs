namespace AcademicSystem
{
    partial class StudentForm
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
            dgvGrades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // dgvGrades
            // 
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(12, 12);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.Size = new Size(240, 150);
            dgvGrades.TabIndex = 0;
            dgvGrades.CellContentClick += dataGridView1_CellContentClick;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGrades);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGrades;
    }
}