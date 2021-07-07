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
    public partial class ProfessorForm : Form {
        public ProfessorForm() {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }




        public Guid ID { get; private set; }
        public string FullName { get; set; }

        public string Tittle { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }


        public void Student(Guid ID) {

            ID = Guid.NewGuid();
        }


        private ProfessorForm professor;
        public ProfessorForm(ProfessorForm professor) {
            this.professor = professor;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string fullname = tbFullName2.Text;
            string title = tbTittle.Text;
            string email = tbEmail2.Text;
            string adress = tbAdress2.Text;

            // i need to put more control statements
            if (string.IsNullOrEmpty(fullname)) {
                MessageBox.Show("At lease Professor name must be filled");
                return;
            }
            professor.FullName = tbFullName2.Text;
            professor.Tittle= tbTittle.Text;
            professor.Email = tbEmail2.Text;
            professor.Adress = tbAdress2.Text;


            MessageBox.Show("The Professor " + professor.FullName + " was created");



            this.Close();

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
    }
