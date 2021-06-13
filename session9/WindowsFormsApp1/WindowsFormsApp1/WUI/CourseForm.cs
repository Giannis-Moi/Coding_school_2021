using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {
    public partial class CourseForm : Form {

        public Course NewCourse { get; set; }

        // CONSTRUCTOR

        public CourseForm() {
            InitializeComponent();
        }

        private void ctrlSave_Click(object sender, EventArgs e) {
            if (ctrlSubject.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT Course
                NewCourse.Subject = Convert.ToString(ctrlSubject.EditValue);

                NewCourse.Hours = Convert.ToInt32(ctrlHours.EditValue);



                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Subject!");
            }
        
    }

        private void ctrlExit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    } 
}
