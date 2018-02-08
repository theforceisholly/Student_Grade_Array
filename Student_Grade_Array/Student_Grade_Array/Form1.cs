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
    }
}
