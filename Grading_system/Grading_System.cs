using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;







namespace Grading_system
{



    public partial class Grading_System : Form
    {
        public Grading_System()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            // Parse grades 
            double prelim = double.TryParse(txtPrilim.Text, out double p) ? p : 0;
            double midterm = double.TryParse(txtMidTerm.Text, out double m) ? m : 0;
            double finals = double.TryParse(txtFinal.Text, out double f) ? f : 0;

            // Calculate average
            double average = (prelim + midterm + finals) / 3;
            txtAverage.Text = average.ToString("F2");

            // Determine remarks (pass if average >= 75)
            bool isPassed = average >= 75;
            txtRemarks.Text = isPassed ? "Passed" : "Failed";

            // Color the average textbox
            txtAverage.BackColor = isPassed ? Color.LightGreen : Color.LightCoral;

            // Display course and fullname
            txtFullname.Text = $"Name: {txtName.Text}         Course: {txtCourse.Text} ";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Parse the grades from the text boxes
            double prelim = double.TryParse(txtPrilim.Text, out double p) ? p : 0;
            double midterm = double.TryParse(txtMidTerm.Text, out double m) ? m : 0;
            double finals = double.TryParse(txtFinal.Text, out double f) ? f : 0;
                
            // Calculate the average
            double average = (prelim + midterm + finals) / 3;

            // Display the result
            txtAverage.Text = average.ToString("F2"); // Shows 2 decimal places
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
