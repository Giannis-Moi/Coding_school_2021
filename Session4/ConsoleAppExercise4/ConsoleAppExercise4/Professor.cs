using System;

namespace ConsoleAppExercise4 {
    public class Professor : Person {

        public string Rank { get; set; }
        private Course[] Courses;

        public Professor(Guid id, string name, int age, string rank, Course[] courses) : base(id, name, age) {

            this.Rank = rank;
            this.Courses = courses;
        }



        public void Teach(Course course, DateTime datetime) {

        }

        public void SetGrade(Guid studentid, Guid courseId, int grade) {

        }

        public override string getName() {
            return "Dr. " + base.getName();
        }
    }
}
