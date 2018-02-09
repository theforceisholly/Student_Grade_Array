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
            this.tbStudentGrades = new System.Windows.Forms.TabControl();
            this.tbStudentDetails = new System.Windows.Forms.TabPage();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnEnterDetails = new System.Windows.Forms.Button();
            this.lblScience = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblEnterMarks = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblEnterMark = new System.Windows.Forms.Label();
            this.tbGrades = new System.Windows.Forms.TabPage();
            this.tbResults = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGStudentNumber1 = new System.Windows.Forms.Label();
            this.lblStudentMarks1 = new System.Windows.Forms.Label();
            this.lblStudentMarks2 = new System.Windows.Forms.Label();
            this.lblGStudentName = new System.Windows.Forms.Label();
            this.lblGStudentNumber = new System.Windows.Forms.Label();
            this.lblGGroup = new System.Windows.Forms.Label();
            this.lblGEnglish = new System.Windows.Forms.Label();
            this.lblGMaths = new System.Windows.Forms.Label();
            this.lblGScience = new System.Windows.Forms.Label();
            this.txtGStudentNumber1 = new System.Windows.Forms.TextBox();
            this.txtGStudentName = new System.Windows.Forms.TextBox();
            this.txtGStudentNumber = new System.Windows.Forms.TextBox();
            this.txtGGroup = new System.Windows.Forms.TextBox();
            this.txtGEnglish = new System.Windows.Forms.TextBox();
            this.txtGMaths = new System.Windows.Forms.TextBox();
            this.txtGScience = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbStudentGrades.SuspendLayout();
            this.tbStudentDetails.SuspendLayout();
            this.tbGrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentGrades
            // 
            this.lblStudentGrades.AutoSize = true;
            this.lblStudentGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGrades.Location = new System.Drawing.Point(231, 9);
            this.lblStudentGrades.Name = "lblStudentGrades";
            this.lblStudentGrades.Size = new System.Drawing.Size(162, 25);
            this.lblStudentGrades.TabIndex = 0;
            this.lblStudentGrades.Text = "Student Grades";
            // 
            // tbStudentGrades
            // 
            this.tbStudentGrades.Controls.Add(this.tbStudentDetails);
            this.tbStudentGrades.Controls.Add(this.tbGrades);
            this.tbStudentGrades.Controls.Add(this.tbResults);
            this.tbStudentGrades.Location = new System.Drawing.Point(12, 66);
            this.tbStudentGrades.Name = "tbStudentGrades";
            this.tbStudentGrades.SelectedIndex = 0;
            this.tbStudentGrades.Size = new System.Drawing.Size(585, 282);
            this.tbStudentGrades.TabIndex = 1;
            // 
            // tbStudentDetails
            // 
            this.tbStudentDetails.Controls.Add(this.txtScience);
            this.tbStudentDetails.Controls.Add(this.txtMaths);
            this.tbStudentDetails.Controls.Add(this.txtEnglish);
            this.tbStudentDetails.Controls.Add(this.cboGroup);
            this.tbStudentDetails.Controls.Add(this.txtStudentNumber);
            this.tbStudentDetails.Controls.Add(this.txtStudentName);
            this.tbStudentDetails.Controls.Add(this.btnEnterDetails);
            this.tbStudentDetails.Controls.Add(this.lblScience);
            this.tbStudentDetails.Controls.Add(this.lblMaths);
            this.tbStudentDetails.Controls.Add(this.lblEnglish);
            this.tbStudentDetails.Controls.Add(this.lblEnterMarks);
            this.tbStudentDetails.Controls.Add(this.lblGroup);
            this.tbStudentDetails.Controls.Add(this.lblStudentNumber);
            this.tbStudentDetails.Controls.Add(this.lblStudentName);
            this.tbStudentDetails.Controls.Add(this.lblEnterMark);
            this.tbStudentDetails.Location = new System.Drawing.Point(4, 22);
            this.tbStudentDetails.Name = "tbStudentDetails";
            this.tbStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentDetails.Size = new System.Drawing.Size(577, 256);
            this.tbStudentDetails.TabIndex = 0;
            this.tbStudentDetails.Text = "Student Details";
            this.tbStudentDetails.UseVisualStyleBackColor = true;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(435, 142);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(100, 20);
            this.txtScience.TabIndex = 14;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(435, 102);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(100, 20);
            this.txtMaths.TabIndex = 13;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(435, 62);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 20);
            this.txtEnglish.TabIndex = 12;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Items.AddRange(new object[] {
            "DPD1A",
            "DPD1B",
            "BRF1A",
            "BRF1B"});
            this.cboGroup.Location = new System.Drawing.Point(133, 141);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(121, 21);
            this.cboGroup.TabIndex = 11;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(133, 102);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(121, 20);
            this.txtStudentNumber.TabIndex = 10;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(133, 59);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(167, 20);
            this.txtStudentName.TabIndex = 9;
            // 
            // btnEnterDetails
            // 
            this.btnEnterDetails.Location = new System.Drawing.Point(463, 209);
            this.btnEnterDetails.Name = "btnEnterDetails";
            this.btnEnterDetails.Size = new System.Drawing.Size(99, 32);
            this.btnEnterDetails.TabIndex = 8;
            this.btnEnterDetails.Text = "Enter Details";
            this.btnEnterDetails.UseVisualStyleBackColor = true;
            this.btnEnterDetails.Click += new System.EventHandler(this.btnEnterDetails_Click);
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Location = new System.Drawing.Point(353, 141);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(46, 13);
            this.lblScience.TabIndex = 7;
            this.lblScience.Text = "Science";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(353, 102);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(36, 13);
            this.lblMaths.TabIndex = 6;
            this.lblMaths.Text = "Maths";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(353, 62);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(41, 13);
            this.lblEnglish.TabIndex = 5;
            this.lblEnglish.Text = "English";
            // 
            // lblEnterMarks
            // 
            this.lblEnterMarks.AutoSize = true;
            this.lblEnterMarks.Location = new System.Drawing.Point(317, 33);
            this.lblEnterMarks.Name = "lblEnterMarks";
            this.lblEnterMarks.Size = new System.Drawing.Size(153, 13);
            this.lblEnterMarks.TabIndex = 4;
            this.lblEnterMarks.Text = "Please enter the student marks";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(37, 141);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 3;
            this.lblGroup.Text = "Group";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(37, 102);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNumber.TabIndex = 2;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(37, 62);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblEnterMark
            // 
            this.lblEnterMark.AutoSize = true;
            this.lblEnterMark.Location = new System.Drawing.Point(7, 33);
            this.lblEnterMark.Name = "lblEnterMark";
            this.lblEnterMark.Size = new System.Drawing.Size(153, 13);
            this.lblEnterMark.TabIndex = 0;
            this.lblEnterMark.Text = "Please enter the student marks";
            // 
            // tbGrades
            // 
            this.tbGrades.Controls.Add(this.btnSearch);
            this.tbGrades.Controls.Add(this.txtGScience);
            this.tbGrades.Controls.Add(this.txtGMaths);
            this.tbGrades.Controls.Add(this.txtGEnglish);
            this.tbGrades.Controls.Add(this.txtGGroup);
            this.tbGrades.Controls.Add(this.txtGStudentNumber);
            this.tbGrades.Controls.Add(this.txtGStudentName);
            this.tbGrades.Controls.Add(this.txtGStudentNumber1);
            this.tbGrades.Controls.Add(this.lblGScience);
            this.tbGrades.Controls.Add(this.lblGMaths);
            this.tbGrades.Controls.Add(this.lblGEnglish);
            this.tbGrades.Controls.Add(this.lblGGroup);
            this.tbGrades.Controls.Add(this.lblGStudentNumber);
            this.tbGrades.Controls.Add(this.lblGStudentName);
            this.tbGrades.Controls.Add(this.lblStudentMarks2);
            this.tbGrades.Controls.Add(this.lblStudentMarks1);
            this.tbGrades.Controls.Add(this.lblGStudentNumber1);
            this.tbGrades.Location = new System.Drawing.Point(4, 22);
            this.tbGrades.Name = "tbGrades";
            this.tbGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tbGrades.Size = new System.Drawing.Size(577, 256);
            this.tbGrades.TabIndex = 1;
            this.tbGrades.Text = "Grades";
            this.tbGrades.UseVisualStyleBackColor = true;
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(4, 22);
            this.tbResults.Name = "tbResults";
            this.tbResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbResults.Size = new System.Drawing.Size(577, 256);
            this.tbResults.TabIndex = 2;
            this.tbResults.Text = "Results";
            this.tbResults.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(479, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGStudentNumber1
            // 
            this.lblGStudentNumber1.AutoSize = true;
            this.lblGStudentNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGStudentNumber1.Location = new System.Drawing.Point(21, 19);
            this.lblGStudentNumber1.Name = "lblGStudentNumber1";
            this.lblGStudentNumber1.Size = new System.Drawing.Size(126, 20);
            this.lblGStudentNumber1.TabIndex = 0;
            this.lblGStudentNumber1.Text = "Student Number";
            // 
            // lblStudentMarks1
            // 
            this.lblStudentMarks1.AutoSize = true;
            this.lblStudentMarks1.Location = new System.Drawing.Point(6, 62);
            this.lblStudentMarks1.Name = "lblStudentMarks1";
            this.lblStudentMarks1.Size = new System.Drawing.Size(76, 13);
            this.lblStudentMarks1.TabIndex = 1;
            this.lblStudentMarks1.Text = "Student Marks";
            // 
            // lblStudentMarks2
            // 
            this.lblStudentMarks2.AutoSize = true;
            this.lblStudentMarks2.Location = new System.Drawing.Point(357, 62);
            this.lblStudentMarks2.Name = "lblStudentMarks2";
            this.lblStudentMarks2.Size = new System.Drawing.Size(76, 13);
            this.lblStudentMarks2.TabIndex = 2;
            this.lblStudentMarks2.Text = "Student Marks";
            // 
            // lblGStudentName
            // 
            this.lblGStudentName.AutoSize = true;
            this.lblGStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGStudentName.Location = new System.Drawing.Point(21, 84);
            this.lblGStudentName.Name = "lblGStudentName";
            this.lblGStudentName.Size = new System.Drawing.Size(93, 16);
            this.lblGStudentName.TabIndex = 3;
            this.lblGStudentName.Text = "Student Name";
            // 
            // lblGStudentNumber
            // 
            this.lblGStudentNumber.AutoSize = true;
            this.lblGStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGStudentNumber.Location = new System.Drawing.Point(21, 128);
            this.lblGStudentNumber.Name = "lblGStudentNumber";
            this.lblGStudentNumber.Size = new System.Drawing.Size(104, 16);
            this.lblGStudentNumber.TabIndex = 4;
            this.lblGStudentNumber.Text = "Student Number";
            // 
            // lblGGroup
            // 
            this.lblGGroup.AutoSize = true;
            this.lblGGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGGroup.Location = new System.Drawing.Point(22, 170);
            this.lblGGroup.Name = "lblGGroup";
            this.lblGGroup.Size = new System.Drawing.Size(45, 16);
            this.lblGGroup.TabIndex = 5;
            this.lblGGroup.Text = "Group";
            // 
            // lblGEnglish
            // 
            this.lblGEnglish.AutoSize = true;
            this.lblGEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGEnglish.Location = new System.Drawing.Point(381, 84);
            this.lblGEnglish.Name = "lblGEnglish";
            this.lblGEnglish.Size = new System.Drawing.Size(52, 16);
            this.lblGEnglish.TabIndex = 6;
            this.lblGEnglish.Text = "English";
            // 
            // lblGMaths
            // 
            this.lblGMaths.AutoSize = true;
            this.lblGMaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMaths.Location = new System.Drawing.Point(381, 128);
            this.lblGMaths.Name = "lblGMaths";
            this.lblGMaths.Size = new System.Drawing.Size(44, 16);
            this.lblGMaths.TabIndex = 7;
            this.lblGMaths.Text = "Maths";
            // 
            // lblGScience
            // 
            this.lblGScience.AutoSize = true;
            this.lblGScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGScience.Location = new System.Drawing.Point(381, 170);
            this.lblGScience.Name = "lblGScience";
            this.lblGScience.Size = new System.Drawing.Size(57, 16);
            this.lblGScience.TabIndex = 8;
            this.lblGScience.Text = "Science";
            // 
            // txtGStudentNumber1
            // 
            this.txtGStudentNumber1.Location = new System.Drawing.Point(163, 19);
            this.txtGStudentNumber1.Name = "txtGStudentNumber1";
            this.txtGStudentNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtGStudentNumber1.TabIndex = 9;
            // 
            // txtGStudentName
            // 
            this.txtGStudentName.Location = new System.Drawing.Point(163, 83);
            this.txtGStudentName.Name = "txtGStudentName";
            this.txtGStudentName.Size = new System.Drawing.Size(171, 20);
            this.txtGStudentName.TabIndex = 10;
            // 
            // txtGStudentNumber
            // 
            this.txtGStudentNumber.Location = new System.Drawing.Point(163, 127);
            this.txtGStudentNumber.Name = "txtGStudentNumber";
            this.txtGStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtGStudentNumber.TabIndex = 11;
            // 
            // txtGGroup
            // 
            this.txtGGroup.Location = new System.Drawing.Point(163, 169);
            this.txtGGroup.Name = "txtGGroup";
            this.txtGGroup.Size = new System.Drawing.Size(100, 20);
            this.txtGGroup.TabIndex = 12;
            // 
            // txtGEnglish
            // 
            this.txtGEnglish.Location = new System.Drawing.Point(463, 83);
            this.txtGEnglish.Name = "txtGEnglish";
            this.txtGEnglish.Size = new System.Drawing.Size(73, 20);
            this.txtGEnglish.TabIndex = 13;
            // 
            // txtGMaths
            // 
            this.txtGMaths.Location = new System.Drawing.Point(463, 127);
            this.txtGMaths.Name = "txtGMaths";
            this.txtGMaths.Size = new System.Drawing.Size(73, 20);
            this.txtGMaths.TabIndex = 14;
            // 
            // txtGScience
            // 
            this.txtGScience.Location = new System.Drawing.Point(463, 169);
            this.txtGScience.Name = "txtGScience";
            this.txtGScience.Size = new System.Drawing.Size(73, 20);
            this.txtGScience.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(269, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbStudentGrades);
            this.Controls.Add(this.lblStudentGrades);
            this.Name = "frmStudentGrades";
            this.Text = "Student Grades";
            this.tbStudentGrades.ResumeLayout(false);
            this.tbStudentDetails.ResumeLayout(false);
            this.tbStudentDetails.PerformLayout();
            this.tbGrades.ResumeLayout(false);
            this.tbGrades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentGrades;
        private System.Windows.Forms.TabControl tbStudentGrades;
        private System.Windows.Forms.TabPage tbStudentDetails;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnEnterDetails;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblEnterMarks;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblEnterMark;
        private System.Windows.Forms.TabPage tbGrades;
        private System.Windows.Forms.TabPage tbResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGScience;
        private System.Windows.Forms.Label lblGMaths;
        private System.Windows.Forms.Label lblGEnglish;
        private System.Windows.Forms.Label lblGGroup;
        private System.Windows.Forms.Label lblGStudentNumber;
        private System.Windows.Forms.Label lblGStudentName;
        private System.Windows.Forms.Label lblStudentMarks2;
        private System.Windows.Forms.Label lblStudentMarks1;
        private System.Windows.Forms.Label lblGStudentNumber1;
        private System.Windows.Forms.TextBox txtGScience;
        private System.Windows.Forms.TextBox txtGMaths;
        private System.Windows.Forms.TextBox txtGEnglish;
        private System.Windows.Forms.TextBox txtGGroup;
        private System.Windows.Forms.TextBox txtGStudentNumber;
        private System.Windows.Forms.TextBox txtGStudentName;
        private System.Windows.Forms.TextBox txtGStudentNumber1;
        private System.Windows.Forms.Button btnSearch;
    }
}

