using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab3_Class_Exercise
{
    public partial class Form1 : Form
    {
        // DO NOT CHANGE
        private Student myStudent;

        // DO NOT CHANGE
        public Form1()
        {
            InitializeComponent();

            myStudent = new Student();

        }

        // DO NOT CHANGE
        private void textBoxGrade_TextChanged(object sender, EventArgs e)
        {

        }

        // DO NOT CHANGE
        private void BtnDisplayInfo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxGrade.text, out double grade))
            {
                myStudent.AdjustGPA(grade);
            }
            else
            {
                MessageBox.Show("invalid grade entered. please enter a valid numeric value.");
            }

            MessageBox.Show($"auto-generated getter example\nstudent gpa: {myStudent._gpa:f2}");
            myStudent.DisplayInformation();
        }
    }
}
