namespace Student_Grade_Array
{
    partial class frmStudentGrades
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
            this.lblStudentGrades = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentGrades
            // 
            this.lblStudentGrades.AutoSize = true;
            this.lblStudentGrades.Location = new System.Drawing.Point(208, 13);
            this.lblStudentGrades.Name = "lblStudentGrades";
            this.lblStudentGrades.Size = new System.Drawing.Size(81, 13);
            this.lblStudentGrades.TabIndex = 0;
            this.lblStudentGrades.Text = "Student Grades";
            // 
            // frmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 421);
            this.Controls.Add(this.lblStudentGrades);
            this.Name = "frmStudentGrades";
            this.Text = "Student Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentGrades;
    }
}

