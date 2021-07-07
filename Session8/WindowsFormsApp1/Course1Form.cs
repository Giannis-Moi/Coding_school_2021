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
    public partial class CourseForm : Form {
        public CourseForm() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        public Guid ID { get; private set; }
        public string Subject { get; set; }

        public string Professors { get; set; }

        public string Ects { get; set; }

        public string Description { get; set; }


        public void Student(Guid ID) {

            ID = Guid.NewGuid();
        }



        private CourseForm course1;
        public CourseForm(CourseForm course1) {
            this.course1 = course1;
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e) {
            string subject = tbSubject.Text;
            string professors = tbProfessors.Text;
            string ects = tbEcts.Text;
            string description = tbDiscription.Text;


            if (string.IsNullOrEmpty(subject)) {
                MessageBox.Show("At least Subject must be filled");
                return;
            }

            course1.Subject = tbSubject.Text;
            course1.Professors = tbProfessors.Text;
            course1.Ects = tbEcts.Text;
            course1.Description = tbDiscription.Text;


            MessageBox.Show("The course " + course1.Subject + " was created");



            this.Close();

        }

        private void button2_Click(object sender, EventArgs e) {

            this.Close();
        }
    }
}