using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade_Array
{
    public partial class frmStudentGrades : Form
    {
        //variables and arrays
        const int arraysize = 30;
        private static String[] strStudentName = new String[arraysize];
        private static String[] strStudentNumber = new String[arraysize];
        private static String[] strGroup = new String[arraysize];

        private static int[] intEnglish = new int[arraysize];
        private static int[] intMaths = new int[arraysize];
        private static int[] intScience = new int[arraysize];

        private static int intRecordCount = 0;
        private static int intLoopCounter = 0;
        private static float fAverage = 0;
        private static String strGrade = "";

        public frmStudentGrades()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //calling the halt procedure
            Halt();
        }

        //procedure to exit
        public static void Halt()
        {
            //local variable to store result
            DialogResult dr;

            //accept response
            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            //if yes then close program
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEnterDetails_Click(object sender, EventArgs e)
        {
            //enter student details
            EnterDetails();
        }

        //procedure to enter student details
        public void EnterDetails()
        {
            strStudentName[intRecordCount] = txtStudentName.Text;
            strStudentNumber[intRecordCount] = txtStudentNumber.Text;
            strGroup[intRecordCount] = cboGroup.Text;

            intEnglish[intRecordCount] = Convert.ToInt32(txtEnglish.Text);
            intMaths[intRecordCount] = Convert.ToInt32(txtMaths.Text);
            intScience[intRecordCount] = Convert.ToInt32(txtScience.Text);

            //increase counter
            intRecordCount++;

            //display message
            MessageBox.Show("Info saved");

            //clear form
            ClearDetails();
        }

        //procedure to clear all details
        public void ClearDetails()
        {
            txtStudentName.Text = "";
            txtStudentNumber.Text = "";
            cboGroup.Text = "";

            txtEnglish.Text = "";
            txtMaths.Text = "";
            txtScience.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check records entered
            if (intRecordCount == 0)
            {
                MessageBox.Show("No records entered");
                return;
            }

            //search through array
            for (int intLoopCounter = 0; intLoopCounter < intRecordCount; intLoopCounter++)
            {
                if (txtSearchNumber.Text.Equals(strStudentNumber[intLoopCounter]))
                {
                    txtName.Text = "" + strStudentName[intLoopCounter];
                    txtNumber.Text = "" + strStudentNumber[intLoopCounter];
                    txtGGroup.Text = "" + strGroup[intLoopCounter];
                    txtEnglishMark.Text = "" + intEnglish[intLoopCounter];
                    txtMathsMark.Text = "" + intMaths[intLoopCounter];
                    txtScienceMark.Text = "" + intScience[intLoopCounter];

                    //add additinal code to display all values
                    intRecordCount = intLoopCounter;
                    return;
                }
            }

            MessageBox.Show("No match found");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculate average mark
            intLoopCounter = intRecordCount - 1;
            fAverage = AverageMark(intEnglish[intRecordCount], intMaths[intRecordCount], intScience[intRecordCount]);

            //calculate average mark
            strGrade = CalculateGrade(fAverage);

            //display result details
            DisplayDetails();
        }

        //function to calculate average mark
        public float AverageMark( int intNumber1, int intNumber2, int intNumber3)
        {
            float Average = (float)(intNumber1 + intNumber2 + intNumber3) / 3;
            return Average;
        }

        //function to enter student details
        public string CalculateGrade(float Mark)
        {
            string strFinalGrade = "";
            if (Mark >= 80)
            {
                strFinalGrade = "You achieved a Distinction";
            }
            else if (Mark >= 60)
            {
                strFinalGrade = "You achieved a Merit";
            }
            else if (Mark >= 40)
            {
                strFinalGrade = "You achieved a Pass";
            }
            else
            {
                strFinalGrade = "You must take a resit";
            }

            return strFinalGrade;
        }

        //procedure to enter student details
        public void DisplayDetails()
        {
            lblStudentDetails.Text = strGroup[intLoopCounter] + ":   " + strStudentNumber[intRecordCount] + ":   " + strStudentName[intRecordCount];
            lblAverageMark.Text = fAverage.ToString("#0.00");
            lblStudentGrade.Text = strGrade;
        }
    }
}
