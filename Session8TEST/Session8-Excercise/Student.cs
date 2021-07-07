using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8_Excercise {
    public class Student {

        //Properties
        public Guid ID { get; private set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Adress { get; set; }

    }

    //Constructor

    private Student student;
    public StudentForm(Student student) {
        this.student = student;
        InitializeComponent();
    }



    //public void Student(Guid id) {

    //id = Guid.NewGuid();


}
