using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise4 {
    public class Student : Person {

        public int RegisterNumber { get; }

        public Course[] Courses { get; set; }

        public Student(Guid id, string name, int age, int Rnumber, Course[] course) : base(id, name, age) {


            this.Courses = course;
            this.RegisterNumber = Rnumber;

        }

        public void Attend(Course course, DateTime dateTime) {

        }

        public void WriteExam(Course course, DateTime dateTime) {

        }


    }
}
