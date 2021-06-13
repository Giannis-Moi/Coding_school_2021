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
    public partial class ProfessorForm : Form {
        public Professor NewProfessor { get; set; }

        // CONSTRUCTOR
        public ProfessorForm() {
            InitializeComponent();
        }

        private void ctrlSave_Click(object sender, EventArgs e) {
            if (ctrlName.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT PROFESSOR
                NewProfessor.Name = Convert.ToString(ctrlName.EditValue);

                NewProfessor.Surname = Convert.ToString(ctrlSurname.EditValue);

                NewProfessor.Rank = Convert.ToString(ctrlRank.EditValue);

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Name!");
            }
        }

        private void ctrlExit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
