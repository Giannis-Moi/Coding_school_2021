using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class MainForm : Form {

        List<Student> Students = new List<Student>();


        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            //MessageBox.Show("Hello World!");
        }

        private void button1_Click(object sender, EventArgs e) {
            //textBox1.Text = "Hello World!";

            //checkBox1.Checked = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {

            Student student = new Student();
            // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!

            // TODO: OPEN FORM ...
            StudentForm form = new StudentForm(student);
            form.ShowDialog();


            //TODO: WHEN FORM THE CLOSES ADD THE STUDENT TO A STUDENT LIST
            if (!string.IsNullOrEmpty(student.FullName)) {

                Students.Add(student);
            }

            Console.WriteLine(student.FullName + "Just show me this output");




        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e) {

        }
        //Opens the Professor form 
        private void button5_Click(object sender, EventArgs e) {
            ProfessorForm professor = new ProfessorForm();

            ProfessorForm form = new ProfessorForm(professor);
            form.ShowDialog();



        }

        private void button3_Click(object sender, EventArgs e) {
            CourseForm courseForm = new CourseForm();

            CourseForm form = new CourseForm(courseForm);
            form.ShowDialog();
        }
    }
}
