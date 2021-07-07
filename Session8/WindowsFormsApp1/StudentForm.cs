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

    public partial class StudentForm : Form {

        // PROPERTIES ????
        //public string Fullname;
        //public string Email;
        //public int MobileNumber;
        //public string Adress;

        // CONSTRUCTOR

        //public StudentForm(string fullname, string email, int mobileNumber, string adress) {

        //    Fullname = fullname;
        //    Email = email;
        //    MobileNumber = mobileNumber;
        //    Adress = adress;
        //}




        
        
        
        //Constructor
        private Student student;
        public StudentForm(Student student ) {
            this.student = student;
            InitializeComponent();
        }


        // METHODS
        private void StudentForm_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            
            string fullname = tbFullName.Text;
            string email = tbEmail.Text;
            string mobileNumber = tbMobile.Text;
            string adress = tbAdress.Text;
            

            if (string.IsNullOrEmpty(fullname) ) {
                MessageBox.Show("At lease Student name must be filled");
                return;
                
            }
            student.FullName = tbFullName.Text;
            student.Email = tbEmail.Text;
            student.Mobile = tbMobile.Text;
            student.Adress = tbAdress.Text;


            MessageBox.Show("The student " + student.FullName + " was created");



            this.Close();


            // todo: MODIFY THE OBJECT STUDENT -- CLOSE THE FORM!

        }

        private void button2_Click(object sender, EventArgs e) {

            // todo: CANCEL EVERYTHING -- DO NOT MODIFY THE OBJECT!

            this.Close();

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        
        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
